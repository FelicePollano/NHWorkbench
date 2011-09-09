// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using MSBuild = Microsoft.Build.BuildEngine;
using System.IO;
using log4net;
using NHibernate.Tool.WorkBench.Helpers;
using NHibernate.Tool.WorkBench.Events;
using HqlIntellisense;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Mapping;
using Microsoft.Build.BuildEngine;
using NHibernate.Tool.WorkBench.Tasks;
namespace NHibernate.Tool.WorkBench.Project
{
    [Model]
    class ProjectModel
    {
        MSBuild.Project project;
        MSBuild.Engine engine;
        ILog logger;
        public string CurrentPath { get; private set; }
        static int ProjectCount = 0;
        string newName;
        string guid;
        public ProjectModel(ILog logger)
        {
            
            this.logger = logger;
            New();
            guid = Guid.NewGuid().ToString();
           
        }

        private const string BUILD_TARGET = "Build";
        private const string HBM2NET_TARGET = "hbm2net";

        public string FileName
        {
            get { return CurrentPath == null ? newName : Path.GetFileNameWithoutExtension(CurrentPath); }
        }

        public bool IsDirty()
        {
            return project.IsDirty;
        }
        MSBuild.BuildItemGroup contents;
        MSBuild.BuildItemGroup assemblies;
        public void New()
        {
            if (null != engine)
                engine.Shutdown();
            contents = null;
            assemblies = null;
            this.logger = LogManager.GetLogger("Build");
            
            engine = new MSBuild.Engine();
            project = new MSBuild.Project(engine, "3.5");
            engine.RegisterLogger(new MSBuildLoggerAdapter(logger));
            newName = string.Concat("Project", (++ProjectCount).ToString());
            CurrentPath = null;
           
        }

        private void EnsureUsingTasks()
        {
            
            bool usingOk = false;
            foreach (UsingTask usin in project.UsingTasks)
            {
                if (usin.TaskName == typeof(Hbm2netTask).FullName)
                    usingOk = true;
               
            }
            if (usingOk == false)
            {
                project.AddNewUsingTaskFromAssemblyFile(typeof(Hbm2netTask).FullName, typeof(Hbm2netTask).Assembly.Location);
            }
            return;
        }
        Target EnsureMainTarget()
        {
            foreach (Target t in project.Targets)
            {
                if (t.Name == BUILD_TARGET)
                    return t;
            }
            return project.Targets.AddNewTarget(BUILD_TARGET);
        }
        Target EnsureHbm2NetTarget()
        {
            foreach (Target t in project.Targets)
            {
                if (t.Name == HBM2NET_TARGET)
                    return t;
            }
            Target tNew = project.Targets.AddNewTarget(HBM2NET_TARGET);
            EnsureMainTarget().DependsOnTargets = tNew.Name;
            return tNew;
        }

        void AddFolderForHBM2Net(string folder)
        {
            Target t = EnsureHbm2NetTarget();
            t.AddNewTask(typeof(Hbm2netTask).FullName);    
        }

        public void Save(string p)
        {
            try
            {
                //if (File.Exists(p))
                //    File.Delete(p);
                project.Save(p);
                if (!string.IsNullOrEmpty(p) && !p.Equals(CurrentPath,StringComparison.OrdinalIgnoreCase))
                {
                    Repath(Path.GetDirectoryName(p));
                }
                CurrentPath = p;
            }
            catch (Exception e)
            {
                logger.Error("Error saving project", e);
            }
        }
        public event EventHandler<ProjectFileMoved> projectFileMoved;
        private void Repath(string projectPath)
        {
            foreach (MSBuild.BuildItemGroup ig in project.ItemGroups)
            {
                foreach (MSBuild.BuildItem bi in ig.ToArray())
                {
                    if (bi.HasMetadata("Type") && bi.GetMetadata("Type") != "Assembly")
                    {
                        string prjFile = GetFilePathForItem(bi);
                        string newPath = Path.Combine(projectPath, Path.GetFileName(prjFile));
                        if (!newPath.Equals(prjFile, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Copy(prjFile, newPath);
                            if (null != projectFileMoved)
                            {
                                projectFileMoved(this, new ProjectFileMoved() { PreviousPath = prjFile, NewPath = newPath });
                            }
                        }
                    }
                }
            }

            if (CurrentPath == null)
            {
                Directory.Delete(GetPathForReferredFiles(), true);
            }
        }

        public void Open(string p)
        {
            try
            {
                New();
                project.Load(p);
                foreach (MSBuild.BuildItemGroup group in project.ItemGroups)
                {
                    foreach (MSBuild.BuildItem bi in group)
                    {
                        if (bi.HasMetadata("Type"))
                        {
                            if (assemblies == null && bi.GetMetadata("Type") == "Assembly")
                            {
                                assemblies = group;
                            }
                            if (contents == null && bi.GetMetadata("Type") != "Assembly")
                            {
                                contents = group;
                            }
                        }
                    }
                }
                CurrentPath = p;
            }
            catch (Exception e)
            {
                logger.Error("Error opening project", e);
            }
        }
        private string GetPathForReferredFiles()
        {
            return CurrentPath != null ? Path.GetDirectoryName(CurrentPath) : Path.Combine(Path.GetTempPath(), guid);
        }
        private bool IsFileInPath(string path, string filePath)
        {
            return Path.GetDirectoryName(filePath).Equals(path, StringComparison.OrdinalIgnoreCase);
        }
        void EnsureContentItems()
        {
            if( null == contents )
                contents = project.AddNewItemGroup();
            
        }
        void EnsureAssembliesItems()
        {
            if (null == assemblies)
                assemblies = project.AddNewItemGroup();

        }

        private string MoveFileIfRequired(string file)
        {
            if (!Directory.Exists(GetPathForReferredFiles()))
                Directory.CreateDirectory(GetPathForReferredFiles());
            if (!IsFileInPath(GetPathForReferredFiles(), file))
            {
                string moved = Path.Combine(GetPathForReferredFiles(), Path.GetFileName(file));
                File.Copy(file, moved,true);
                return moved;
            }
            else
            {
                return file;
            }
        }

        public MSBuild.Project GetProject()
        {
            return project;
        }

       public  string GetFilePathForItem(Microsoft.Build.BuildEngine.BuildItem buildItem)
        {
            return Path.Combine(GetPathForReferredFiles(), buildItem.Include);
        }

       public void Close()
       {
           try
           {
               engine.UnloadAllProjects();
               engine.Shutdown();
               Directory.Delete(GetPathForReferredFiles(), true);
           }
           catch(Exception e)
           {

           }
       }



       public MSBuild.BuildItem RenameContent(string prev, string current)
       {
           MSBuild.BuildItem ret = null;
           foreach (MSBuild.BuildItemGroup ig in project.ItemGroups)
           {
               foreach (MSBuild.BuildItem bi in ig.ToArray())
               {
                   string prjFile = GetFilePathForItem(bi);
                   if (prjFile.Equals(prev, StringComparison.OrdinalIgnoreCase) && IsFileInPath(GetPathForReferredFiles(),current))
                   {
                       bi.Include = Path.GetFileName(current);
                       ret = bi;
                       break;
                   }
               }
           }
           return ret;
       }

       public MSBuild.BuildItem ClassifyAndAdd(string path)
       {
           if (Path.GetExtension(path).Equals(".config"))
           {
               return AddConfig(path);
           }
           else
           if (path.EndsWith(".hbm.xml",StringComparison.OrdinalIgnoreCase))
           {
               return AddMapping(path);
           }
           else
               if (Path.GetExtension(path).Equals(".xml"))
               {
                   return AddConfig(path);
               }
               else
                   if (Path.GetExtension(path).Equals(".dll") || Path.GetExtension(path).Equals(".exe"))
                   {
                       return AddAssembly(path);
                   }
                   else
                       if (Path.GetExtension(path).Equals(".hql") )
                       {
                           return AddHql(path);
                       }
           return null;
       }

       private MSBuild.BuildItem AddHql(string path)
       {
           return AddContent(path, "Hql");
       }

       private MSBuild.BuildItem AddAssembly(string path)
       {
           return AddContentAssembly(path);
       }

       private MSBuild.BuildItem AddMapping(string path)
       {
           return AddContent(path, "Mapping");
       }

       public MSBuild.BuildItem AddConfig(string config)
       {
           return AddContent(config, "Config");
       }

       private MSBuild.BuildItem AddContent(string content, string type)
       {
           EnsureContentItems();
           try
           {
               string itemLoc = MoveFileIfRequired(content);
               var item = contents.AddNewItem("Content", Path.GetFileName(itemLoc));

               item.SetMetadata("Type", type);
               return item;
           }
           catch (Exception e)
           {
               logger.Error("Error adding file to a project:", e);
               return null;
           }
       }

       private MSBuild.BuildItem AddContentAssembly(string content)
       {
           EnsureAssembliesItems();
           try
           {
               
               var item = assemblies.AddNewItem("Content", content);
               item.SetMetadata("Type", "Assembly");
               return item;
           }
           catch (Exception e)
           {
               logger.Error("Error adding file to a project:", e);
               return null;
           }
       }


       public void RemoveItem(MSBuild.BuildItem buildItem)
       {
           foreach (MSBuild.BuildItemGroup ig in project.ItemGroups)
           {
               foreach (MSBuild.BuildItem bi in ig.ToArray())
               {
                   if (bi == buildItem)
                   {
                       ig.RemoveItem(buildItem);
                       break;
                   }
               }
           }
       }

       public string GetBinaryPath()
       {
           if (null == assemblies)
           {
               throw new Exception("No mapping assembly specified");
           }
           HashSet<string> paths = new HashSet<string>();
           foreach (MSBuild.BuildItem it in assemblies)
           {
               paths.Add(Path.GetDirectoryName(it.Include).ToLower());
           }
           if (paths.Count == 0)
           {
               throw new Exception("No mapping assembly specified");
           }

           if (paths.Count > 1)
           {
               throw new Exception("Mapping assemblies does not share the same directory.");
           }

           return paths.Distinct().First();
       }

       public void SetActiveConfiguration(Microsoft.Build.BuildEngine.BuildItem buildItem)
       {
           foreach (MSBuild.BuildItem bi in contents)
           {
               if (IsConfiguration(bi))
               {
                   if (bi != buildItem)
                       bi.RemoveMetadata("Active");
                   else
                       bi.SetMetadata("Active", "true");
               }
           }
       }

       public bool IsConfiguration(Microsoft.Build.BuildEngine.BuildItem bi)
       {
           return bi.HasMetadata("Type") && bi.GetMetadata("Type").Equals("Config");
       }

       public bool IsActiveConfiguration(Microsoft.Build.BuildEngine.BuildItem item)
       {
           return IsConfiguration(item) &&
               item.HasMetadata("Active") && item.GetMetadata("Active").Equals("true");
       }
       MSBuild.BuildItem GetActiveConfiguration()
       {
           foreach (MSBuild.BuildItem bi in contents)
           {
               if (IsActiveConfiguration(bi))
                   return bi;
           }
           return null;
       }
       public string GetActiveConfigurationFile()
       {
           MSBuild.BuildItem cfg = GetActiveConfiguration();
           if (null != cfg)
               return Path.Combine(GetPathForReferredFiles(), cfg.Include);
           return string.Empty;
       }

       public string[] GetMappingAssemblies()
       {
           List<string> s = new List<string>();
           foreach (MSBuild.BuildItem bi in assemblies)
           {
               s.Add(bi.Include);
           }
           return s.ToArray();
       }
       public void Build()
       {
           EnsureUsingTasks();
           EnsureMainTarget();
           AddFolderForHBM2Net(".\\");
           project.Build(BUILD_TARGET);
       }
    }
}

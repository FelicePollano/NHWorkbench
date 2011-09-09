// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HqlIntellisense.ConfigurationAbstraction;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.CommandDefs;
using System.Windows.Forms;
using Effectus.Infrastructure;
using System.IO;
using NHibernate.Tool.WorkBench.Events;
using log4net;
using NHibernate.Tool.WorkBench.Helpers;
using log4net.Core;
using HqlIntellisense;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using NHibernate.Cfg;
using NHibernate.Mapping;

namespace NHibernate.Tool.WorkBench.Project
{
    [Presenter]
    [Export(Type = typeof(IConfigurationDataProvider))]
    [Export(Type = typeof(IQueryTranslator) )]
    class ProjectPresenter:IPresenter,IConfigurationDataProvider,IQueryTranslator
    {
        ProjectView view;
        ProjectModel model;
        ILog logger;
        
        public ProjectPresenter(ProjectView view,ProjectModel model,ILog logger)
        {
            this.view = view;
            this.logger = logger;
            probeLogger = LogManager.GetLogger("Probe");
            view.Disposed += new EventHandler(view_Disposed);
            this.model = model;
            view.CreateNewProject += new EventHandler(view_CreateNewProject);
            view.SaveProjectAs += new EventHandler(view_SaveProjectAs);
            view.SaveProject += new EventHandler(view_SaveProject);
            view.OpenProject += new EventHandler(view_OpenProject);
            view.OpenFileRequest += new EventHandler<NHibernate.Tool.WorkBench.Events.OpenFileRequest>(view_OpenFileRequest);
            view.AddMappingAssembly += new EventHandler(view_AddMappingAssembly);
            view.AddConfig += new EventHandler(view_AddConfig);
            view.AddItem += new EventHandler(view_AddItem);
            view.RemoveItem += new EventHandler(view_RemoveItem);
            view.AddMappingAssembly+=new EventHandler(view_AddMappingAssembly);
            view.ActivateConfiguration += new EventHandler(view_ActivateConfiguration);
            view.UpdateRootName(model);
            view.Showproject(model);
            view.CreateProbe += new EventHandler(view_CreateProbe);
            model.projectFileMoved += new EventHandler<ProjectFileMoved>(model_projectFileMoved);
            EventPublisher.Register((FileNameChanged e) => OnFileNameChanged(e));
        }

        void view_ActivateConfiguration(object sender, EventArgs e)
        {
            model.SetActiveConfiguration(view.SelectedItem);
        }
        Probe probe;
        ILog probeLogger;
        AppDomain probeAppDomain;
        IDictionary<string, string> imports;
        
        void view_CreateProbe(object sender, EventArgs e)
        {
            try
            {
                if (null != probeAppDomain)
                {
                    probeLogger.Warn("Unloading app domain");
                    AppDomain.Unload(probeAppDomain);
                    probeAppDomain = null;
                }
                model.Build();
                AppDomainSetup info = new AppDomainSetup();
                info.ApplicationBase = model.GetBinaryPath();
                string activeConf = model.GetActiveConfigurationFile();
                if( !string.IsNullOrEmpty( activeConf ) )
                {
                    if (Path.GetExtension(activeConf).Equals(".config",StringComparison.OrdinalIgnoreCase))
                    {
                        logger.Warn(string.Concat("File:",activeConf," will be used as a configuration file for the probe app domain"));
                        info.ConfigurationFile = activeConf;
                    }
                }
                
                probeAppDomain = AppDomain.CreateDomain("Probe",null,info);
                probe = probeAppDomain.CreateInstanceFromAndUnwrap(typeof(Probe).Assembly.Location, typeof(Probe).FullName) as Probe;
                probe.ToolPath = Path.GetDirectoryName(typeof(Probe).Assembly.Location);
                probe.LoggerURI = ApplicationEnvironment.Instance.LoggerURI;

                probe.Assemblies = model.GetMappingAssemblies();

                

                probe.Configure();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                imports =  ser.Deserialize<Dictionary<string, string>>(probe.Imports);
            }
            catch (Exception exc)
            {
                logger.Error("Error creating probe domain", exc);
            }
        }
       
       

        void view_RemoveItem(object sender, EventArgs e)
        {
            if (null != view.SelectedItem)
            {
                model.RemoveItem(view.SelectedItem);
                view.RemoveSelectedNode();
            }
        }

        void view_AddItem(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));

            sfd.Filter = ApplicationEnvironment.Instance.GetCombinedFilters();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var item = model.ClassifyAndAdd(sfd.FileName);
                if (model.IsConfiguration(item))
                {
                    model.SetActiveConfiguration(item);
                }
                view.InsertItem(item);
            }
        }

        void model_projectFileMoved(object sender, ProjectFileMoved e)
        {
            EventPublisher.Publish(e, this);
        }

        private void OnFileNameChanged(FileNameChanged e)
        {
            var item = model.RenameContent(e.PrevPath, e.NewPath);
            if( null != item )
                view.UpdateItem(item);
        }

        void view_Disposed(object sender, EventArgs e)
        {
            Cleanup();
        }

        private void Cleanup()
        {
            if (string.IsNullOrEmpty(model.CurrentPath))
            {
                model.Close();
            }
        }

        void view_OpenFileRequest(object sender, NHibernate.Tool.WorkBench.Events.OpenFileRequest e)
        {
            EventPublisher.Publish(e,this);
        }

        void view_AddConfig(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));
            if (string.IsNullOrEmpty(sfd.InitialDirectory))
                sfd.InitialDirectory = ApplicationEnvironment.Instance.DocumentPath;
            sfd.Filter = ApplicationEnvironment.Instance.ConfigFilterString;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var item = model.AddConfig(sfd.FileName);
                model.SetActiveConfiguration(item);
                view.InsertConfigItem(item);
            }
        }

        void view_AddMappingAssembly(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));
            if (string.IsNullOrEmpty(sfd.InitialDirectory))
                sfd.InitialDirectory = ApplicationEnvironment.Instance.DocumentPath;
            sfd.Filter = ApplicationEnvironment.Instance.AssemblyFilterString;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var item = model.ClassifyAndAdd(sfd.FileName);
                if (null != item)
                {
                    view.InsertItem(item);
                }
            }
        }


        void view_OpenProject(object sender, EventArgs e)
        {
            if (model.IsDirty())
            {
                DialogResult res = MessageBox.Show("Save changes to current project ?", "Project unsaved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    view_SaveProject(this, EventArgs.Empty);
                    OpenProject();
                }
                if (res == DialogResult.No)
                {
                    OpenProject();
                }

            }
            else
            {
                OpenProject();
            }
        }

        private void OpenProject()
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));
            sfd.DefaultExt = "nhproj";
            if (string.IsNullOrEmpty(sfd.InitialDirectory))
                sfd.InitialDirectory = ApplicationEnvironment.Instance.DocumentPath;
            sfd.Filter = "NHWorkBench Project Files  (*.nhproj)|*.nhproj|All files (*.*)|*.*";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                model.Open(sfd.FileName);
                view.UpdateRootName(model);
                view.Showproject(model);
            }
        }

        void view_SaveProject(object sender, EventArgs e)
        {
            if (null == model.CurrentPath)
            {
                view_SaveProjectAs(this, EventArgs.Empty);
            }
            else
            {
                model.Save(model.CurrentPath);
            }
        }

        void view_SaveProjectAs(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));
            sfd.DefaultExt = "nhproj";
            //if (string.IsNullOrEmpty(sfd.InitialDirectory))
            //    sfd.InitialDirectory = ApplicationEnvironment.Instance.DocumentPath;
            sfd.Filter = "NHWorkBench Project Files  (*.nhproj)|*.nhproj";
            sfd.FileName = model.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string prev = model.FileName;
                model.Save(sfd.FileName);
                if (sfd.FileName != prev)
                    view.UpdateRootName(model);
            }
        }

        void view_CreateNewProject(object sender, EventArgs e)
        {
            if (model.IsDirty())
            {
                DialogResult res = MessageBox.Show("Save changes to current project ?", "Project unsaved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    view_SaveProject(this, EventArgs.Empty);
                    model.New();
                }
                if (res == DialogResult.No)
                {
                    model.New();
                }

            }
            else
            {
                model.New();
            }
            view.UpdateRootName(model);
            view.Showproject(model);
        }
       
        #region IPresenter Members

        public object View
        {
            get { return view; }
        }

        public event EventHandler Disposed;

        public void Startup()
        {
           
        }

        #endregion



        #region IConfigurationDataProvider Members

        public IDictionary<string, string> Imports
        {
            get 
            {
                if (null == probe)
                {
                    return new Dictionary<string, string>();
                }
                else
                {
                    return imports;
                }
            }
        }

        public IPersistentClassInformation GetClassMapping(string path)
        {
			var rc = new RootClass();
			foreach (string p in probe.GetProperties(path))
			{
			    var ser = new JavaScriptSerializer();
			    var obj = ser.DeserializeObject(p) as IDictionary<string,object>;
			    var prop = new Property();
			    prop.Value = NHValueJSonHelper.JSonDeserialize(prop.GetType().Assembly, obj["Value"] as IDictionary<string,object>) as IValue;
			    prop.Name = obj["Name"] as string; 
			    rc.AddProperty( prop);
			}
        	return ConfigurationMapper.MapClass(rc);
        }

		public IPersistentClassInformation GetClassMapping(System.Type type)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IQueryTranslator Members

        public ExecutedHqlResults Translate(string hql)
        {
            if (null != probe)
            {
                return probe.HqlToSql(hql);
            }
            else
            {
                return new ExecutedHqlResults() { Body="Project not compiled" };
            }
        }

        public string[] Execute(string hql, int first, int max)
        {
            if (null != probe)
            {
                return probe.ExecuteQuery(hql,first,max);
            }
            else
            {
                return new string[0];
            }
        }


        #endregion
    }
}

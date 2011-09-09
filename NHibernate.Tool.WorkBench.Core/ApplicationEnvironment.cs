// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace NHibernate.Tool.WorkBench.Core
{
    public class ApplicationEnvironment
    {
        private ApplicationEnvironment()
        {
            
        }
        public readonly string ConfigFilterString = "All Configuration files  (*.xml;*.config)|*.xml;*.config|NHibernate Configuration files  (*.xml)|*.xml|Application configuration files (*.config)|*.config|All files (*.*)|*.*";
        public readonly string MappingFilterString = "Mapping files  (*.hbm.xml)|*.hbm.xml|All files (*.*)|*.*";
        public readonly string HqlFilterString = "Hql files  (*.hql)|*.hql|All files (*.*)|*.*";
        public readonly string AssemblyFilterString = "Asselmbly files  (*.dll;*.exe)|*.dll;*.exe|All files (*.*)|*.*";
        static ApplicationEnvironment instance;
        public string  LoggerURI { get; set; }
        public static ApplicationEnvironment Instance
        {
            get
            {
                lock (typeof(ApplicationEnvironment))
                {
                    if (null == instance)
                        instance = new ApplicationEnvironment();
                }
                return instance;
            }
        }
        public long UserId { get; set; }

        public string DocumentPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"NHibernate Workbench"); }
        }

        public string DockigSettings
        {
            get 
            {
                return Path.Combine(DataPath, "docking.layout");
            }
        }
        public string DataPath 
        {
            get
            {
                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Assembly.GetExecutingAssembly().GetName().Name);
                try
                {
                    if (!Directory.Exists(dataPath))
                        Directory.CreateDirectory(dataPath);
                }
                finally
                {
                    
                }
                return dataPath;
            }
        }


        public string GetCombinedFilters()
        {
            List<string> filters = new List<string>();
            foreach (var field in GetType().GetFields())
            {
                if (field.Name.EndsWith("FilterString"))
                {
                    filters.AddRange((field.GetValue(this) as string).Split('|'));
                }
            }
            HashSet<string> extensions = new HashSet<string>();
            for (int i = 1; i < filters.Count; i += 2)
            {
                foreach (string ext in filters[i].Split(';'))
                {
                    string ex = ext.Trim();
                    if (!ex.Equals("*.*"))
                    {
                        extensions.Add(ex);
                    }
                }
            }
            return string.Concat("All Handled Files ("
                            ,GetExtensions(extensions)
                            ,")|"
                             ,GetExtensions(extensions)
                             ,"|All files (*.*)|*.*");
        }

        private string GetExtensions(HashSet<string> extensions)
        {
            return string.Join(";", extensions.ToArray());
        }
    }
}

// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Mapping;
using NHibernate;

namespace HqlIntellisense
{
    public class NHConfigDataProvider:IConfigurationDataProvider
    {
        NHibernate.Cfg.Configuration cfg;
        public NHConfigDataProvider(NHibernate.Cfg.Configuration cfg)
        {
            this.cfg = cfg;
        }

        #region IConfigurationDataProvider Members
        public IDictionary<string, string> Imports
        {
            get { return cfg.Imports; }
        }
        public NHibernate.Mapping.PersistentClass GetClassMapping(string path)
        {
            return cfg.GetClassMapping(path) ?? cfg.ClassMappings.FirstOrDefault(cm => cm.ClassName == path);
        }
        public NHibernate.Mapping.PersistentClass GetClassMapping(Type type)
        {
            return cfg.GetClassMapping(type);
        }
        #endregion
    }
}

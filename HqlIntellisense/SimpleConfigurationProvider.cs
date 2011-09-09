// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using HqlIntellisense.ConfigurationAbstraction;
using NHibernate.Cfg;

namespace HqlIntellisense
{
    public class SimpleConfigurationProvider : IConfigurationDataProvider
    {
    	private readonly IEnumerable<IPersistentClassInformation> classes;


    	public SimpleConfigurationProvider(Configuration cfg)
        {
			var mapper = new ConfigurationMapper(cfg);
    		classes = mapper.GetClasses();
    		Imports = cfg.Imports;
        }

    	#region IConfigurationDataProvider Members
		public IDictionary<string, string> Imports
		{
			get; private set;
		}
        public IPersistentClassInformation GetClassMapping(string path)
        {
        	return classes.FirstOrDefault(c => c.ClassName == path);
        }
		public IPersistentClassInformation GetClassMapping(Type type)
        {
			throw new NotImplementedException();
        }
        #endregion
    }
}

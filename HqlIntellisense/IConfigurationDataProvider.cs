// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using HqlIntellisense.ConfigurationAbstraction;

namespace HqlIntellisense
{
    public interface IConfigurationDataProvider
    {
        IDictionary<string, string> Imports { get; }

        IPersistentClassInformation GetClassMapping(string path);

		IPersistentClassInformation GetClassMapping(Type type);
    }
}

using System;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentProperty : IPersistentProperty
	{
		public PersistentProperty(string name, IPersistentValue value)
		{
			Name = name;
			Value = value;
		}

		public string Name
		{
			get; private set;
		}

		public IPersistentValue Value
		{
			get; private set;
		}
	}
}
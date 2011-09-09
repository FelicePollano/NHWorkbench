using System;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentOneToMany : IPersistentOneToMany
	{
		public PersistentOneToMany(string referencedEntityName)
		{
			ReferencedEntityName = referencedEntityName;
		}

		public string ReferencedEntityName
		{
			get; private set;
		}
	}
}
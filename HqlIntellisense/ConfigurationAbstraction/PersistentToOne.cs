using System;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentToOne : IPersistentToOne
	{
		public PersistentToOne(string referencedEntityName)
		{
			ReferencedEntityName = referencedEntityName;
		}

		public string ReferencedEntityName
		{
			get; private set;
		}
	}
}
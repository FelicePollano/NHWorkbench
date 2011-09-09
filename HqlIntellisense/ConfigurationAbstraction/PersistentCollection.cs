using System;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentCollection : IPersistentCollection
	{
		public PersistentCollection(IPersistentValue element)
		{
			Element = element;
		}

		public IPersistentValue Element
		{
			get; private set;
		}
	}
}
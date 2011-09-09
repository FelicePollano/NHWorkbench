using System;
using System.Collections.Generic;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentComponent : IPersistentComponent
	{
		public PersistentComponent(IEnumerable<IPersistentProperty> properties)
		{
			Properties = properties;
		}

		public IEnumerable<IPersistentProperty> Properties
		{
			get; private set;
		}
	}
}
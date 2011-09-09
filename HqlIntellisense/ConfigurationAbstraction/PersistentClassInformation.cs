using System;
using System.Collections.Generic;
using System.Linq;

namespace HqlIntellisense.ConfigurationAbstraction
{
	[Serializable]
	public class PersistentClassInformation : IPersistentClassInformation
	{
		#region IPersistentClassInformation Members

		public IEnumerable<IPersistentProperty> Properties { get; set; }

		public string EntityName { get; set; }

		public IPersistentIdentifier IdentifierProperty { get; set; }

		public string ClassName { get; set; }

		public IPersistentProperty GetProperty(string attribute)
		{
			return Properties.FirstOrDefault(p => p.Name == attribute);
		}

		#endregion
	}
}
using System.Collections.Generic;
using System.Linq;
using NHibernate.Cfg;
using NHibernate.Mapping;

namespace HqlIntellisense.ConfigurationAbstraction
{
	public class ConfigurationMapper
	{
		private readonly Configuration configuration;

		public ConfigurationMapper(Configuration configuration)
		{
			this.configuration = configuration;
		}

		public IEnumerable<IPersistentClassInformation> GetClasses()
		{
			return configuration.ClassMappings.Select(cm => MapClass(cm)).ToArray();
		}

		public static IPersistentClassInformation MapClass(PersistentClass cm)
		{
			return new PersistentClassInformation
			       	{
			       		EntityName = cm.EntityName,
			       		ClassName = cm.ClassName,
			       		IdentifierProperty =cm.IdentifierProperty == null ? null : 
			       		                                                         	new PersistentIdentifierProperty(cm.IdentifierProperty.Name,
			       		                                                         	                                 MapValue(cm.IdentifierProperty.Value)),
			       		Properties = MapProperties(cm.PropertyIterator).ToArray()
			       	};
		}

		public static IEnumerable<IPersistentProperty> MapProperties(IEnumerable<Property> propertyIterator)
		{
			return propertyIterator.Select(p => new PersistentProperty(p.Name, MapValue(p.Value))).OfType<IPersistentProperty>();
		}

		public static IPersistentValue MapValue(IValue value)
		{
			var component = value as Component;
			if(component != null)
			{
				return new PersistentComponent(MapProperties(component.PropertyIterator));
			}
			var collection = value as Collection;
			if(collection != null)
			{
				return new PersistentCollection(MapValue(collection.Element));
			}
			var toOne = value as ToOne;
			if(toOne != null)
			{
				return new PersistentToOne(toOne.ReferencedEntityName);
			}

			var oneToMany = value as OneToMany;
			if(oneToMany != null)
			{
				return new PersistentOneToMany(oneToMany.ReferencedEntityName);
			}
			return null;
		}
	}
}
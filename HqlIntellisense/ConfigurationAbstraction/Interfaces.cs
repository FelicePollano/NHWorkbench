using System.Collections.Generic;

namespace HqlIntellisense.ConfigurationAbstraction
{

	public interface IPersistentClassInformation
	{
		IEnumerable<IPersistentProperty> Properties { get; }
		string EntityName { get; }
		IPersistentIdentifier IdentifierProperty { get; set; }
		string ClassName { get; }
		IPersistentProperty GetProperty(string attribute);
	}

	public interface IPersistentIdentifier
	{
		string Name { get; }
		IPersistentValue Value { get; }
	}

	public interface IPersistentValue
	{
	}

	public interface IPersistentProperty
	{
		string Name { get; }
		IPersistentValue Value { get; }
	}

	public interface IPersistentComponent : IPersistentValue
	{
		IEnumerable<IPersistentProperty> Properties { get; }
	}

	public interface IPersistentCollection : IPersistentValue
	{
		IPersistentValue Element { get; }
	}
	public interface IPersistentToOne : IPersistentValue
	{
		string ReferencedEntityName { get; }
	}

	public interface IPersistentOneToMany : IPersistentValue
	{
		string ReferencedEntityName { get; }
	}
}
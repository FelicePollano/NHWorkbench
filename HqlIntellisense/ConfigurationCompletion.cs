// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using HqlIntellisense.ConfigurationAbstraction;
using NHibernate;
using NHibernate.Mapping;
using Array = System.Array;

namespace HqlIntellisense
{
	internal class ConfigurationCompletion
	{
		private readonly IConfigurationDataProvider cfg;

		public ConfigurationCompletion(IConfigurationDataProvider cfg)
		{
			this.cfg = cfg;
		}

		public void GetMatchingImports(string prefix, IHQLCompletionRequestor collector)
		{
			GetMatchingImports(prefix, prefix.Length, collector);
		}

		public void GetMatchingImports(string prefix, int cursorPosition, IHQLCompletionRequestor collector)
		{
			if (null != cfg.Imports)
			{
				foreach (var entry in cfg.Imports)
				{
					string entityImport = entry.Key;
					string entityName = entry.Value;
					if (entityImport.ToLower().StartsWith(prefix.ToLower()))
					{
						HQLCompletionProposal proposal = CreateStartWithCompletionProposal(prefix, cursorPosition,
						                                                                   CompletionKind.EntityName, entityImport);
						proposal.ShortEntityName = entityImport;
						proposal.EntityName = entityName;
						collector.Accept(proposal);
					}
				}
			}
		}

		public void GetMatchingKeywords(string prefix, int cursorPosition, IHQLCompletionRequestor collector)
		{
			FindMatchingWords(cursorPosition, prefix, HQLAnalyzer.GetHQLKeywords(), CompletionKind.KeyWord, collector);
		}

		public void GetMatchingFunctions(string prefix, int cursorPosition, IHQLCompletionRequestor collector)
		{
			FindMatchingWords(cursorPosition, prefix, HQLAnalyzer.GetHQLFunctionNames(), CompletionKind.Function, collector);
		}

		public void GetMatchingProperties(string path, string prefix, IHQLCompletionRequestor hcc)
		{
			GetMatchingProperties(path, prefix, prefix.Length, hcc);
		}

		public void GetMatchingProperties(string path, string prefix, int cursorPosition, IHQLCompletionRequestor hcc)
		{
			int idx = path.IndexOf('/');
			if (idx == -1)
			{
				// root name
				IPersistentClassInformation cmd = GetPersistentClass(path);
				if (cmd == null)
				{
					return;
				}
				AddPropertiesToList(cmd, prefix, cursorPosition, hcc);
			}
			else
			{
				string baseEntityName = path.Substring(0, idx);
				string propertyPath = path.Substring(idx + 1);
				IPersistentValue value = GetNextAttributeType(baseEntityName, propertyPath);
				if (value == null)
				{
					return;
				}

				// Go to the next property (get the y of x/y/z when root is x)
				idx = propertyPath.IndexOf('/');
				path = idx == -1 ? "" : propertyPath.Substring(idx + 1);
				if (path.Length == 0)
				{
					// No properties left
					if (value is IPersistentComponent)
					{
						AddPropertiesToList((IPersistentComponent) value, prefix, cursorPosition, hcc);
					}
					else if (value is IPersistentCollection && ((IPersistentCollection) value).Element is IPersistentComponent)
					{
						AddPropertiesToList((IPersistentComponent) ((Collection) value).Element, prefix, cursorPosition, hcc);
					}
					else
					{
						AddPropertiesToList(GetPersistentClass(GetReferencedEntityName(value)), prefix, cursorPosition, hcc);
					}
				}
				else
				{
					// Nested properties
					if (value is Component)
					{
						// We need to find the first non-component type 
						while (value is Component && path.Length > 0)
						{
							value = GetNextAttributeType((IPersistentComponent) value, path);
							if (value != null)
							{
								// Consume part of the canonical path
								idx = path.IndexOf('/');
								path = idx != -1 ? path.Substring(idx + 1) : "";
							}
						}
						if (value is Component)
						{
							AddPropertiesToList((IPersistentComponent) value, prefix, cursorPosition, hcc);
						}
						else if (value != null)
						{
							if (path.Length > 0)
							{
								path = GetReferencedEntityName(value) + "/" + path;
							}
							else
							{
								path = GetReferencedEntityName(value);
							}
							GetMatchingProperties(path, prefix, cursorPosition, hcc);
						}
					}
					else
					{
						// Just call the method recursively to add our new type
						GetMatchingProperties(GetReferencedEntityName(value) + "/" + path, prefix, cursorPosition, hcc);
					}
				}
			}
		}

		private static string GetReferencedEntityName(IPersistentValue value)
		{
			var persistentToOne = value as IPersistentToOne;
			if (persistentToOne != null)
			{
				return persistentToOne.ReferencedEntityName;
			}
			var persistentCollection = value as IPersistentCollection;
			if (persistentCollection != null)
			{
				IPersistentCollection collection = persistentCollection;
				IPersistentValue element = collection.Element;
				string elementType = GetReferencedEntityName(element);
				/*
			    if(collection.isIndexed()) {*/
				//TODO..list/map
				/*IndexedCollection idxCol = (IndexedCollection) collection;
				    if(!idxCol.isList()) {
					    Value idxElement = idxCol.getIndex();
					    string indexType = getReferencedEntityName( value );
					    genericDecl = indexType + "," + elementType;
				    }*/
				/*} */
				return elementType;
			}

			var oneToMany = value as IPersistentOneToMany;
			if (oneToMany != null)
			{
				return oneToMany.ReferencedEntityName;
			}

			return null;
		}

		private static void AddPropertiesToList(IPersistentClassInformation cmd, string prefix, int cursorPosition,
		                                        IHQLCompletionRequestor hcc)
		{
			if (cmd == null)
			{
				return;
			}
			if (prefix == null)
			{
				prefix = "";
			}
			foreach (IPersistentProperty p in cmd.Properties)
			{
				string candidate = p.Name;
				if (prefix.Length == 0 || candidate.ToLower().StartsWith(prefix.ToLower()))
				{
					HQLCompletionProposal proposal = CreateStartWithCompletionProposal(prefix, cursorPosition, CompletionKind.Property,
					                                                                   candidate);
					proposal.EntityName = cmd.EntityName;
					proposal.Property = p;
					proposal.PropertyName = candidate;
					hcc.Accept(proposal);
				}
			}
			/*
            EntityPOJOClass pc = new EntityPOJOClass(cmd, new Cfg2JavaTool()); // TODO: we should extract the needed functionallity from this hbm2java class.
            
            Iterator allPropertiesIterator = pc.getAllPropertiesIterator();
            while ( allPropertiesIterator.hasNext() ) {
			    Property property = (Property) allPropertiesIterator.next();
			    string candidate = property.getName();
		        if (prefix.length() == 0 || candidate.toLowerCase().startsWith(prefix.toLowerCase())) {
		    	    HQLCompletionProposal proposal = createStartWithCompletionProposal( prefix, cursorPosition, CompletionKind.Property, candidate );
		    	    proposal.setEntityName( cmd.getEntityName() );
		    	    proposal.setProperty( property );
		    	    proposal.setPropertyName( candidate );		    	
				    hcc.accept( proposal);		    	                
                }
            }*/
		}

		private static HQLCompletionProposal CreateStartWithCompletionProposal(string prefix, int cursorPosition,
		                                                                       CompletionKind kind, string candidate)
		{
			var proposal = new HQLCompletionProposal(kind, cursorPosition)
			               	{
			               		SimpleName = candidate,
			               		ReplaceEnd = cursorPosition
			               	};

			if (candidate.StartsWith(prefix))
			{
				proposal.Completion = candidate.Substring(prefix.Length);
				proposal.ReplaceStart = cursorPosition;
			}
			else
			{
				proposal.Completion = candidate;
				proposal.ReplaceStart = cursorPosition - prefix.Length; // replace prefix	
			}
			return proposal;
		}

		/** returns PersistentClass for path. Can be null if path is an imported non-mapped class */

		private IPersistentClassInformation GetPersistentClass(string path)
		{
			if (path == null) return null;
			string entityName;
			cfg.Imports.TryGetValue(path, out entityName);

			return cfg.GetClassMapping(entityName ?? path);
			//Type t = Type.GetType(entityName); // applied patch from socchetti
			//if (t != null)
			//    return cfg.GetClassMapping(t);
			//else
		}

		public string GetCanonicalPath(List<EntityNameReference> qts, string name)
		{
			IDictionary<string, string> alias2Type = new Dictionary<string, string>();
			foreach (EntityNameReference qt in qts)
			{
				alias2Type[qt.Alias] = qt.EntityName;
			}
			if (qts.Count == 1)
			{
				EntityNameReference visible = qts[0];
				string alias = visible.Alias;
				if (name.Equals(alias))
				{
					return visible.EntityName;
				}
				if (string.IsNullOrEmpty(alias) || alias.Equals(visible.EntityName))
				{
					return visible.EntityName + "/" + name;
				}
			}
			return GetCanonicalPath(new HashSet<string>(), alias2Type, name);
		}

		private static string GetCanonicalPath(HashSet<string> resolved, IDictionary<string, string> alias2Type, string name)
		{
			if (resolved.Contains(name))
			{
				// To prevent a stack overflow
				return name;
			}
			resolved.Add(name);
			string type;
			alias2Type.TryGetValue(name, out type);

			if (type != null)
			{
				return name.Equals(type) ? name : GetCanonicalPath(resolved, alias2Type, type);
			}
			int idx = name.LastIndexOf('.');
			if (idx == -1)
			{
				return name;
			}
			string baseName = name.Substring(0, idx);
			string prop = name.Substring(idx + 1);
			return IsAliasKnown(alias2Type, baseName)
			       	? GetCanonicalPath(resolved, alias2Type, baseName) + "/" + prop
			       	: name;
		}

		private static bool IsAliasKnown(IDictionary<string, string> alias2Type, string alias)
		{
			if (alias2Type.ContainsKey(alias))
			{
				return true;
			}
			int idx = alias.LastIndexOf('.');
			return idx != -1 && IsAliasKnown(alias2Type, alias.Substring(0, idx));
		}

		private IPersistentValue GetNextAttributeType(string type, string attributePath)
		{
			IPersistentClassInformation cmd = GetPersistentClass(type);
			if (cmd == null)
			{
				return null;
			}
			int idx = attributePath.IndexOf('/');
			string attribute = idx == -1 ? attributePath : attributePath.Substring(0, idx);

			string idName = cmd.IdentifierProperty == null ? null : cmd.IdentifierProperty.Name;
			if (attribute.Equals(idName))
			{
				if (cmd.IdentifierProperty != null) return cmd.IdentifierProperty.Value;
			}
			try
			{
				IPersistentProperty property = cmd.GetProperty(attribute);
				return property == null ? null : property.Value;
			}
			catch (HibernateException)
			{
				return null;
			}
		}

		private static IPersistentValue GetNextAttributeType(IPersistentComponent t, string attributeName)
		{
			int idx = attributeName.IndexOf('/');
			if (idx != -1)
			{
				attributeName = attributeName.Substring(0, idx);
			}
			IEnumerable<IPersistentProperty> names = t.Properties;

			return (from element in names
			        let name = element.Name
			        where attributeName.Equals(name)
			        select element.Value).FirstOrDefault();
		}

		private static void AddPropertiesToList(IPersistentComponent t, string prefix, int cursorPosition,
		                                        IHQLCompletionRequestor hcc)
		{
			if (t == null)
			{
				return;
			}
			IEnumerable<IPersistentProperty> props = t.Properties;
			foreach (IPersistentProperty element in props)
			{
				string candidate = element.Name;
				if (candidate.ToLower().StartsWith(prefix.ToLower()))
				{
					HQLCompletionProposal proposal = CreateStartWithCompletionProposal(prefix, cursorPosition, CompletionKind.Property,
					                                                                   candidate);
					//proposal.setEntityName( cmd.getEntityName() ); ...we don't know here..TODO: pass in the "path"
					proposal.PropertyName = candidate;
					proposal.Property = element;
					hcc.Accept(proposal);
				}
			}
		}

		private static void FindMatchingWords(int cursorPosition, string prefix, string[] words, CompletionKind kind,
		                                      IHQLCompletionRequestor hcc)
		{
			int i = Array.BinarySearch(words, prefix.ToLower());
			if (i < 0)
			{
				i = Math.Abs(i + 1);
			}

			for (int cnt = i; cnt < words.Length; cnt++)
			{
				string word = words[cnt];
				if (word.ToLower().StartsWith(prefix.ToLower()))
				{
					HQLCompletionProposal proposal = CreateStartWithCompletionProposal(prefix, cursorPosition, kind, word);
					hcc.Accept(proposal);
				}
				else
				{
					break;
				}
			}
		}
	}
}
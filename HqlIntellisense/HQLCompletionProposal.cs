// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Text;
using HqlIntellisense.ConfigurationAbstraction;

namespace HqlIntellisense
{
	public enum CompletionKind
	{
		EntityName = 1,
		Property = 2,
		KeyWord = 3,
		Function = 4,
		AliasRef = 5 // ref to an alias name, e.g. "bar" in "from Bar as bar where b|"
	}

	public class HQLCompletionProposal
	{
		public HQLCompletionProposal(CompletionKind kind, int cursorPosition)
		{
			EntityName = null;
			ShortEntityName = null;
			PropertyName = null;
			CompletionKind = kind;
			CompletionLocation = cursorPosition;
		}

		/// <summary>
		/// The actual completion. 
		/// </summary>
		public string Completion { get; set; }

		/// <summary>
		/// kind of completion request
		/// </summary>
		public CompletionKind CompletionKind { get; set; }

		/// <summary>
		/// original cursorposition in the query
		/// </summary>
		public int CompletionLocation { get; set; }

		/// <summary>
		/// Relevance rating
		/// </summary>
		public int Relevance { get; set; }

		public int ReplaceEnd { get; set; }
		public int ReplaceStart { get; set; }

		public string SimpleName { get; set; }

		/// <summary>
		/// The full related entity name, the resolved shortEntityName. Can be null 
		/// </summary>
		public string EntityName { get; set; }

		/// <summary>
		/// A short entity name. e.g. the imported name. 
		/// e.g. "Product" instead of "org.hibernate.model.Product" 
		/// (note: a imported name can also be the long version) 
		/// </summary>
		public string ShortEntityName { get; set; }

		/// <summary>
		/// The propertyName, can be null.  
		/// </summary>
		public string PropertyName { get; set; }

		/// <summary>
		/// The underlying property. Can be null.
		/// </summary>
		public IPersistentProperty Property { get; set; }

		/// <summary>
		/// The default name for the entityname, keyword, property etc.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var buffer = new StringBuilder();
			buffer.Append('[');
			switch (CompletionKind)
			{
				case CompletionKind.EntityName:
					buffer.Append("ENTITY_NAME");
					break;
				case CompletionKind.Property:
					buffer.Append("PROPERTY");
					break;
				case CompletionKind.KeyWord:
					buffer.Append("KEYWORD");
					break;
				default:
					buffer.Append("<Unknown type>");
					break;
			}
			buffer.Append("]{completion:"); //$NON-NLS-1$
			if (Completion != null) buffer.Append(Completion);
			buffer.Append(", simpleName:"); //$NON-NLS-1$
			if (SimpleName != null) buffer.Append(SimpleName);
			buffer.Append(", ["); //$NON-NLS-1$
			buffer.Append(ReplaceStart);
			buffer.Append(',');
			buffer.Append(ReplaceEnd);
			buffer.Append("], relevance="); //$NON-NLS-1$
			buffer.Append(Relevance);
			buffer.Append('}');
			return buffer.ToString();
		}
	}
}
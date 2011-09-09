using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Document;
using System.Drawing;
using HqlIntellisense;
using System.Threading;
using Antlr.Runtime;

namespace Fatica.Labs.HqlEditor
{
    class HqlAdvancedHighlightStrategy:IHighlightingStrategy
    {
        IHighlightingStrategy baseStrategy;
       
        public HqlAdvancedHighlightStrategy(IHighlightingStrategy baseStrategy)
        {
            this.baseStrategy = baseStrategy;
        }
        
        #region IHighlightingStrategy Members

        public string[] Extensions
        {
            get
            {
                return baseStrategy.Extensions;
            }
            set
            {
                baseStrategy.Extensions = value;
            }
        }

        public HighlightColor GetColor(IDocument document, LineSegment keyWord, int index, int length)
        {
            return baseStrategy.GetColor(document, keyWord, index, length);
        }

        public HighlightColor GetColorFor(string name)
        {
            return baseStrategy.GetColorFor(name);
        }

        public HighlightRuleSet GetRuleSet(Span span)
        {
            HighlightRuleSet set = baseStrategy.GetRuleSet(span);
            return set;
        }

        public void MarkTokens(IDocument document)
        {
            baseStrategy.MarkTokens(document);
        }

        private HQLAnalyzer analizer = new HQLAnalyzer();
        public void MarkTokens(IDocument document, List<LineSegment> lines)
        {
            var subs = analizer.GetSubQueries(document.TextContent.Replace("\r\n","  "), document.TextLength - 1);
            baseStrategy.MarkTokens(document, lines);
            foreach (var line in lines)
            {
                foreach (var word in line.Words)
                {
                    if (!string.IsNullOrEmpty(word.Word.Trim()))
                    {
                        if (word.Word.StartsWith(":"))
                        {
                            word.SyntaxColor = new HighlightColor(Color.BlueViolet,Color.Yellow, true, false);
                        }
                        else
                        {
                            var visible = analizer.GetVisibleSubQueries(subs, word.Offset + line.Offset);
                            var names = analizer.GetVisibleEntityNames(visible, word.Offset + line.Offset);
                            if (names.Any(q => q.Alias.Equals(word.Word.Split('.')[0])))
                            {
                                word.SyntaxColor = new HighlightColor(Color.DarkGoldenrod, true, true);
                            }
                            else if (names.Any(q => q.EntityName.Equals(word.Word)))
                            {
                                word.SyntaxColor = new HighlightColor(Color.DarkGoldenrod, true, false);
                            }
                        }
                    }
                }
            }
        }

        public string Name
        {
            get { return baseStrategy.Name; }
        }

        public Dictionary<string, string> Properties
        {
            get { return baseStrategy.Properties; }
        }

        #endregion
    }
}

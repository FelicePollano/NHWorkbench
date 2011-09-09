using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Document;
using System.Xml;

namespace Fatica.Labs.HqlEditor
{
    class HqlSyntaxModeFileProvider:ISyntaxModeFileProvider
    {
        #region ISyntaxModeFileProvider Members

        public XmlTextReader GetSyntaxModeFile(SyntaxMode syntaxMode)
        {
            if (syntaxMode.Name.Equals("HQL"))
            {
                return new XmlTextReader(GetType().Assembly.GetManifestResourceStream("Fatica.Labs.HqlEditor.hql-mode.xshd"));
            }
            else
                throw new InvalidOperationException();
        }

        public ICollection<SyntaxMode> SyntaxModes
        {
            get { return new List<SyntaxMode>() { new SyntaxMode(".hql","HQL",".hql") }; }
        }

        public void UpdateSyntaxModeList()
        {
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using System.Windows.Forms;
using HqlIntellisense;
using System.Diagnostics;

namespace Fatica.Labs.HqlEditor
{
    class HqlCompletionDataProvider : AbstractCompletionDataProvider,IHQLCompletionRequestor
    {
        IConfigurationDataProvider cfg;
        public HqlCompletionDataProvider(IConfigurationDataProvider cfg)
        {
            this.cfg = cfg;
        }
       
        List<HQLCompletionData> completion = new List<HQLCompletionData>();

        string preselection;
        public override string PreSelection
        {
            get { return preselection; }
        }

        #region IHQLCompletionRequestor Members

        public bool Accept(HQLCompletionProposal proposal)
        {
            completion.Add(new HQLCompletionData(proposal) { DotStart=DotCompletion });
            return true;
        }

        public void CompletionFailure(string errorMessage)
        {
            
        }

        #endregion
        protected bool DotCompletion { get; set; }
        public override ICompletionData[] GenerateCompletionData(string fileName, ICSharpCode.TextEditor.TextArea textArea, char charTyped)
        {
            preselection = "";
            completion.Clear();
            HQLCodeAssist assist = new HQLCodeAssist(cfg);
            if (charTyped != '.')
            {
                DotCompletion = false;
                assist.CodeComplete(textArea.Document.TextContent.Replace("\r\n","  "), textArea.Caret.Offset, this);
            }
            else
            {
                DotCompletion = true;
                preselection = null;
                assist.CodeComplete(textArea.Document.TextContent.Insert(textArea.Caret.Offset, ".").Replace("\r\n", "  "), textArea.Caret.Offset + 1, this);
            }
            completion.Sort();
            return completion.ToArray();
        }

        public override CompletionDataProviderKeyResult ProcessKey(char key)
        {
            if (key == '\r' || key == '\t')
            {
                return CompletionDataProviderKeyResult.InsertionKey;
            }
            
            return CompletionDataProviderKeyResult.NormalKey;
        }

       
    }
}

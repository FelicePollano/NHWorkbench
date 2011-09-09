using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using HqlIntellisense;

namespace Fatica.Labs.HqlEditor
{
    class HQLCompletionData:ICompletionData,IComparable
    {
        public bool DotStart { get; set; }
        HQLCompletionProposal proposal;
        public HQLCompletionData(HQLCompletionProposal proposal)
        {
            this.proposal = proposal;
        }
        #region ICompletionData Members

        public string Description
        {
            get { return proposal.SimpleName; }
        }

        public int ImageIndex
        {
            get 
            {
                switch (proposal.CompletionKind)
                {
                    case CompletionKind.AliasRef:
                        return 0;
                    case CompletionKind.EntityName:
                        return 1;
                    case CompletionKind.Function:
                        return 2;
                    case CompletionKind.KeyWord:
                        return 3;
                    case CompletionKind.Property:
                        return 4;
                    default: return 5;
                }
            }
        }

        public bool InsertAction(ICSharpCode.TextEditor.TextArea textArea, char ch)
        {
            string completion = proposal.Completion;
            //if (DotStart)
            //    completion = string.Concat(".", completion);
            textArea.InsertString(completion);
            return true;
        }

        public double Priority
        {
            get { return 0; }
        }

        public string Text
        {
            get
            {
                return proposal.SimpleName;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {
            HQLCompletionData rhs = obj as HQLCompletionData;
            return proposal.CompletionKind.CompareTo(rhs.proposal.CompletionKind);
        }

        #endregion
    }
}

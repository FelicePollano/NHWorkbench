// <file>
//     <license GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007 />
//     <owner name="Felice Pollano" email="felice@felicepollano.com"/>
// </file>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using ICSharpCode.TextEditor;

namespace Fatica.Labs.HqlEditor
{
    public abstract class AbstractCompletionDataProvider : ICompletionDataProvider
    {
        ImageListProvider imageProvider = new ImageListProvider();
        public AbstractCompletionDataProvider()
        {

        }
        public virtual ImageList ImageList
        {
            get
            {
                return imageProvider.GetImageList();
            }
        }

        int defaultIndex = -1;

        /// <summary>
        /// Gets the index of the element in the list that is chosen by default.
        /// </summary>
        public int DefaultIndex
        {
            get
            {
                return defaultIndex;
            }
            set
            {
                defaultIndex = value;
            }
        }

        

        public abstract string PreSelection
        {
            get;
        }

        bool insertSpace;

        /// <summary>
        /// Gets/Sets if a space should be inserted in front of the completed expression.
        /// </summary>
        public bool InsertSpace
        {
            get
            {
                return insertSpace;
            }
            set
            {
                insertSpace = value;
            }
        }

        

        public virtual bool InsertAction(ICompletionData data, TextArea textArea, int insertionOffset, char key)
        {
            if (InsertSpace)
            {
                textArea.Document.Insert(insertionOffset++, " ");
            }
            textArea.Caret.Position = textArea.Document.OffsetToPosition(insertionOffset);

            return data.InsertAction(textArea, key);
        }

        /// <summary>
        /// Generates the completion data. This method is called by the text editor control.
        /// This method may return null.
        /// </summary>
        public abstract ICompletionData[] GenerateCompletionData(string fileName, TextArea textArea, char charTyped);

        public abstract CompletionDataProviderKeyResult ProcessKey(char key);
        
    }

    
}

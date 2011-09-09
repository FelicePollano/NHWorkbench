// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.CommandDefs;
using ICSharpCode.TextEditor;
using System.Windows.Forms;
using NHibernate.Tool.WorkBench.Core;
using System.Diagnostics;
using NHibernate.Tool.WorkBench.Events;
using ICSharpCode.TextEditor.Actions;
using System.IO;

namespace NHibernate.Tool.WorkBench
{
    abstract class SupportEditorCommandContent : DockContent, IHaveEditorControl,ISupportsCommands,IHavePath
    {
        string currentPath;

        TextArea textArea;
        public void LoadFile(string path)
        {
            GetEditor().LoadFile(path);
            Dirty = false;
            currentPath = path;
        }
        protected void SetEditor(TextEditorControl textEditorControl)
        {
            textEditorControl.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);
            textArea = textEditorControl.ActiveTextAreaControl.TextArea;
        }

        protected abstract string GetFilterString();

        void Document_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
        {
            Dirty = true;
        }
        bool dirty;
        public bool Dirty 
        {
            get { return dirty; }
            private set { UpdateCaption(dirty,value); dirty = value; } 
        }

        private void UpdateCaption(bool dirty, bool value)
        {
            if (dirty == true && value == false)
            {
                Text = Text.Substring(0,Text.LastIndexOf(" *")+1);
            }
            if (dirty == false && value == true)
            {
                Text = string.Concat(Text, " *");
            }
        }
        
        CommandBinding[] bindings;
        public event EventHandler<FileNameChanged> FileNameChanged;
        public SupportEditorCommandContent()
        {
           
            bindings = new CommandBinding[]
            {
                new CommandBinding(){ Command=DefinedCommands.Save, CanExecute =()=> Dirty , Execute=()=>OnSave()}
                ,new CommandBinding(){ Command=DefinedCommands.SelectAll, CanExecute =()=> true , Execute=()=>SelectAll()}
                ,new CommandBinding(){ Command=DefinedCommands.SaveAs, CanExecute =()=> true, Execute=()=>OnSaveAs()}
                ,new CommandBinding(){ Command=DefinedCommands.Cut, CanExecute =()=> HasSomethingSelected(), Execute=()=>new Cut().Execute(textArea)}
                ,new CommandBinding(){ Command=DefinedCommands.Copy, CanExecute =()=> textArea.SelectionManager.HasSomethingSelected, Execute=()=>new Copy().Execute(textArea)}
                ,new CommandBinding(){ Command=DefinedCommands.Paste, CanExecute =()=> textArea.MotherTextAreaControl!=null && !textArea.Document.ReadOnly, Execute=()=>new Paste().Execute(textArea)}
                ,new CommandBinding(){ Command=DefinedCommands.Undo, CanExecute =()=> textArea.MotherTextAreaControl!=null && textArea.Document.UndoStack.CanUndo, Execute=()=>new Undo().Execute(textArea)}
                ,new CommandBinding(){ Command=DefinedCommands.Redo, CanExecute =()=> textArea.MotherTextAreaControl!=null && textArea.Document.UndoStack.CanRedo, Execute=()=>new Redo().Execute(textArea)}
                
            };
        }

        private void SelectAll()
        {
            var end = textArea.Document.OffsetToPosition(textArea.Document.TextContent.Length);
            textArea.SelectionManager.SetSelection(new TextLocation(0, 0), end);
        }

        private bool HasSomethingSelected()
        {
            return textArea.SelectionManager.HasSomethingSelected;
        }

        private void OnSaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.CustomPlaces.Add(new FileDialogCustomPlace(ApplicationEnvironment.Instance.DocumentPath));
            //sfd.DefaultExt = "nhproj";
            //if (string.IsNullOrEmpty(sfd.InitialDirectory))
            //    sfd.InitialDirectory = ApplicationEnvironment.Instance.DocumentPath;
            sfd.Filter = GetFilterString();
            sfd.FileName = currentPath ??Text.Substring(0,Text.LastIndexOf(" *")+1).Substring(0,Text.IndexOf(".")+1).Trim('.');
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string prev = currentPath;
                Save(sfd.FileName);
                currentPath = sfd.FileName;
                if (sfd.FileName != prev)
                {
                    if (null != FileNameChanged)
                    {
                        FileNameChanged(this, new FileNameChanged() { PrevPath=prev, NewPath=sfd.FileName });
                    }
                }
            }
        }

        private void OnSave()
        {
            if (string.IsNullOrEmpty(currentPath))
            {
                OnSaveAs();
            }
            else
            {
                Save(currentPath);
            }
        }

        private void Save(string path)
        {
            GetEditor().SaveFile(path);
            Dirty = false;
            Text = Path.GetFileName(path);
        }

        #region IHasEditorControl Members
        public abstract ICSharpCode.TextEditor.TextEditorControl GetEditor();
        #endregion

        #region ISupportsCommands Members

        public CommandBinding[] Bindings
        {
            get { return bindings; }
        }

        public bool Active
        {
            get { return IsActivated; }
        }

        #endregion

        #region IHasPath Members

        public string DocPath
        {
            get
            {
                return currentPath;
            }
            set
            {
                currentPath = value;
            }
        }

        #endregion
    }
}

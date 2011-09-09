using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor;
using NHibernate.Cfg;
using ICSharpCode.TextEditor.Document;
using System.Diagnostics;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Actions;
using HqlIntellisense;

namespace Fatica.Labs.HqlEditor
{
    public class HqlEditor:TextEditorControl
    {
        class ControlSpaceProvider : AbstractEditAction
        {
            HqlEditor editor;
            public ControlSpaceProvider(HqlEditor editor)
            {
                this.editor = editor;
            }



            public override void Execute(TextArea textArea)
            {
                editor.ShowCompletionWindow(' ');
            }
        }
        
        CodeCompletionWindow codeCompletionWindow;
        //public Configuration NHCfg { get; set; }
        public IConfigurationDataProvider NHConfigDataProvider { get; set; }
        public HqlEditor()
        {
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new HqlSyntaxModeFileProvider());
            HighlightingManager.Manager.ReloadSyntaxModes();
            Document.HighlightingStrategy = new HqlAdvancedHighlightStrategy(HighlightingManager.Manager.FindHighlighter("HQL"));
            editactions.Add(Keys.Space | Keys.Control, new ControlSpaceProvider(this));
        }

        protected override void InitializeTextAreaControl(TextAreaControl newControl)
        {
            newControl.TextArea.KeyEventHandler += new ICSharpCode.TextEditor.KeyEventHandler(HandleKeyPress);
            base.InitializeTextAreaControl(newControl);
        }
       
        protected bool HandleKeyPress(char ch)
        {
            if (IsCodeCompletionWindowOpen)
            {
                if (codeCompletionWindow.ProcessKeyEvent(ch))
                {
                    return false;
                }
            }

            try
            {
                switch (ch)
                {
                    case '.':
                        ShowCompletionWindow(ch);
                        return false;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                //MessageService.ShowError(e);
                Debug.Assert(false);
            }

            return false;
        }
        void CodeCompletionWindowClosed(object sender, EventArgs e)
        {
            codeCompletionWindow.Closed -= new EventHandler(CodeCompletionWindowClosed);
            codeCompletionWindow.Dispose();
            codeCompletionWindow = null;
        }

        bool IsCodeCompletionWindowOpen
        {
            get
            {
                return ((codeCompletionWindow != null) && (!codeCompletionWindow.IsDisposed));
            }
        }

        void ShowCompletionWindow(char ch)
        {
            if (IsCodeCompletionWindowOpen)
            {
                codeCompletionWindow.Close();
            }
            codeCompletionWindow = CodeCompletionWindow.ShowCompletionWindow(ParentForm, this, FileName, new HqlCompletionDataProvider(NHConfigDataProvider), ch, true/*PROPERTY*/, false);
            
            if (codeCompletionWindow != null)
            {
                codeCompletionWindow.Closed += new EventHandler(CodeCompletionWindowClosed);
            }
        }
        
    }
}

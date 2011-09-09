// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.CommandDefs;
using NHibernate.Tool.WorkBench.Core.WireAttributes.UiHelpers;
namespace NHibernate.Tool.WorkBench.Hql
{
    [PresenterView]
    partial class HqlDocument : SupportEditorCommandContent,ISupportsCommands
    {
        //RawSQLPreview preview;
        //QueryResults results;
        MainForm form;
        CommandBinding[] commandBindings;
        public HqlDocument(MainForm form)
        {
            InitializeComponent();
            this.form = form;

            List<CommandBinding> lcmd = new List<CommandBinding>();
            lcmd.AddRange(base.Bindings);
            lcmd.Add(new CommandBinding() { Command = DefinedCommands.Run, CanExecute = () => CanExecute, Execute = () => OnRun() });
            commandBindings = lcmd.ToArray();

            ShowHint = DockState.Document;
            Show(form.DockPanel);
            SetEditor(GetEditor());
            form.DockPanel.ActiveDocumentChanged += new EventHandler(DockPanel_ActiveDocumentChanged);
           
        }

        void DockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            
        }
       

        protected override string GetFilterString()
        {
            return ApplicationEnvironment.Instance.HqlFilterString;
        }

        public override ICSharpCode.TextEditor.TextEditorControl GetEditor()
        {
            return hqlEditor1;
        }
        public void PresentResults(string[] results)
        {
            //this.results.SetResults(results);
        }
        public void UpdateCanExecute(ExecutedHqlResults res)
        {
            CanExecute = res.Exception==null && !string.IsNullOrEmpty(res.Body.Trim());
        }
        public bool CanExecute { get; internal set; }
        #region ISupportsCommands Members

        CommandBinding[] ISupportsCommands.Bindings
        {
            get {
                return commandBindings;
            }
        }
        public event EventHandler Run;
        private void OnRun()
        {
            using (new WaitCursor())
            {
                if (null != Run)
                    Run(this, EventArgs.Empty);
            }
        }

        bool ISupportsCommands.Active
        {
            get { return this.IsActivated; }
        }

        #endregion
    }
}

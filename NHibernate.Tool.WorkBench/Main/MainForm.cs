using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.CommandDefs;

namespace NHibernate.Tool.WorkBench
{
    [PresenterView(Singleton=true)]
    public partial class MainForm : Form,ISupportsCommands
    {
        
        public MainForm(ICommandRouter router)
        {
            InitializeComponent();
            InitializeCommandBindings(router);
            InitializeSupportedCommands(router);
            FirstResult = 0;
            MaxResults = 100;
            toolStripTextBoxFirst.Control.DataBindings.Add("Text", this, "FirstResult");
            toolStripTextBoxMax.Control.DataBindings.Add("Text", this, "MaxResults");
        }
        public event EventHandler NewConfig;
        public event EventHandler NewHql;
        public event EventHandler NewMapping;
        public event EventHandler OpenFile;
        public int FirstResult { get; set; }
        public int MaxResults { get; set; }
        private void InitializeSupportedCommands(ICommandRouter router)
        {
            bindings = new CommandBinding[]
            {
                new CommandBinding(){ Command=DefinedCommands.NewConfig, CanExecute=()=>true, Execute=()=>{if(null!=NewConfig) NewConfig(this,EventArgs.Empty);}}
                ,new CommandBinding(){ Command=DefinedCommands.NewHql, CanExecute=()=>true, Execute=()=>{if(null!=NewHql) NewHql(this,EventArgs.Empty);}}
                ,new CommandBinding(){ Command=DefinedCommands.NewMapping, CanExecute=()=>true, Execute=()=>{if(null!=NewMapping) NewMapping(this,EventArgs.Empty);}}
                ,new CommandBinding(){ Command=DefinedCommands.OpenFile, CanExecute=()=>true, Execute=()=>{if(null!=OpenFile) OpenFile(this,EventArgs.Empty);}}
            };
            router.Register(this);
        }

        private void InitializeCommandBindings(ICommandRouter router)
        {
            router.BindToUI(DefinedCommands.NewProject, newProject1ToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.NewProject, newProjectToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.SaveProject, toolStripButtonSaveProject, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.SaveProject, toolStripMenuItemSaveProject, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.SaveProjectAs, toolStripMenuItemSaveProjectAs, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.OpenProject, this.openProjectToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.OpenProject, this.openProjectToolStripMenuItem1, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Save, this.saveToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.Save, this.saveToolStripButton, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.SaveAs, this.saveAsToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.SelectAll, this.selectAllToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Copy, this.copyToolStripButton, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.Copy, this.copyToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Cut, this.cutToolStripButton, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.Cut, this.cutToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Paste, this.pasteToolStripButton, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.Paste, this.pasteToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Undo, this.undoToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            
            router.BindToUI(DefinedCommands.Redo, this.redoToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.NewConfig, this.newConfigToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.NewConfig, this.configToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.NewMapping, this.newMappingToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.NewMapping, this.mappingToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.NewHql, this.newHqlToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.NewHql, this.hqlToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.OpenFile, this.openFileToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.OpenFile, this.openToolStripMenuItem, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.CreateProbe, this.buildProbeToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.CreateProbe, this.toolStripButtonBuildProbe, "Click", (i, e) => i.Enabled = e);

            router.BindToUI(DefinedCommands.Run, this.startToolStripMenuItem, "Click", (i, e) => i.Enabled = e);
            router.BindToUI(DefinedCommands.Run, this.toolStripButtonStart, "Click", (i, e) => i.Enabled = e);


        }
        public DockPanel DockPanel { get { return dockPanelMain; } }

        private void dockPanelMain_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        #region ISupportsCommands Members
        CommandBinding[] bindings;
        public CommandBinding[] Bindings
        {
            get { return bindings; }
        }

        public bool Active
        {
            get { return true; }
        }

        #endregion
    }
}

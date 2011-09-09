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
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.CommandDefs;
using NHibernate.Tool.WorkBench.Core.Commands;
using MSBuild = Microsoft.Build.BuildEngine;
using Effectus.Infrastructure;
using NHibernate.Tool.WorkBench.Events;
using System.IO;
using System.Security.Policy;

namespace NHibernate.Tool.WorkBench.Project
{
    [PresenterView(Singleton=true)]
    partial class ProjectView : DockContent, ISupportsCommands
    {
        Font boldTreeFont;
        Font normalTreeFont;
        public ProjectView(MainForm form)
        {
            InitializeComponent();
            bindings = new CommandBinding[]
            {
                new CommandBinding(){ Command=DefinedCommands.NewProject, CanExecute =()=> true , Execute=()=>OnNewProject()}
                ,new CommandBinding(){ Command=DefinedCommands.SaveProject, CanExecute =()=> model != null && model.IsDirty()  , Execute=()=>OnSaveProject()}
                ,new CommandBinding(){ Command=DefinedCommands.SaveProjectAs, CanExecute =()=> true  , Execute=()=>OnSaveProjectAs()}
                ,new CommandBinding(){ Command=DefinedCommands.OpenProject, CanExecute =()=> true  , Execute=()=>OnOpenProject()}
                ,new CommandBinding(){ Command=DefinedCommands.CreateProbe, CanExecute =()=> true  , Execute=()=>OnCreateProbe()}
            };
            ShowHint = DockState.DockRight;
            Show(form.DockPanel);
            boldTreeFont = new Font(treeProject.Font,FontStyle.Bold);
            normalTreeFont = treeProject.Font;
        }

        private void OnCreateProbe()
        {
            if (null != CreateProbe)
            {
                CreateProbe(this, EventArgs.Empty);
            }
        }

        private void OnOpenProject()
        {
            if (null != OpenProject)
            {
                OpenProject(this, EventArgs.Empty);
            }
        }

        private void OnSaveProjectAs()
        {
            if (null != SaveProjectAs)
            {
                SaveProjectAs(this, EventArgs.Empty);
            }
        }

        private void OnSaveProject()
        {
            if (null != SaveProjectAs)
            {
                SaveProject(this, EventArgs.Empty);
            }
        }
        public event EventHandler CreateNewProject;
        public event EventHandler SaveProject;
        public event EventHandler SaveProjectAs;
        public event EventHandler OpenProject;
        public event EventHandler AddItem;
        public event EventHandler RemoveItem;
        public event EventHandler CreateProbe;
        public event EventHandler ActivateConfiguration;

        public void OnNewProject()
        {
            if (CreateNewProject != null)
                CreateNewProject(this, EventArgs.Empty);
        }
        #region ISupportsCommands Members
        CommandBinding[] bindings;
        public CommandBinding[] Bindings
        {
            get { return bindings; }
        }

        public bool Active
        {
            get { return IsActivated; }
        }

        #endregion
        TreeNode root;
        ProjectModel model;
        public void UpdateRootName(ProjectModel model)
        {
            this.model = model;
            if (null == root)
            {
                root = treeProject.Nodes.Add("");
            }
            root.Text = model.FileName;
            root.ImageIndex = root.SelectedImageIndex = 0;
        }
        TreeNode configNode;
        TreeNode mappingAssembliesNode;
        TreeNode mappingFilesNode;
        public void Showproject(ProjectModel model)
        {
            BuildTreeBasicStructure();
            foreach(MSBuild.BuildItemGroup group in model.GetProject().ItemGroups)
            {
                foreach (var item in group.ToArray())
                {
                    InsertItem(item);
                }
            }
        }

        private void InsertMappingAssembly(Microsoft.Build.BuildEngine.BuildItem item)
        {
            var newnode = mappingAssembliesNode.Nodes.Add(Path.GetFileName(item.Include));
            newnode.ToolTipText = item.Include;
            newnode.ImageIndex = newnode.SelectedImageIndex = 3;
            newnode.Tag = item;
        }

        public void InsertConfigItem(Microsoft.Build.BuildEngine.BuildItem item)
        {
            var newnode = configNode.Nodes.Add(item.Include);
            newnode.ToolTipText = item.Include;
            newnode.ImageIndex = newnode.SelectedImageIndex = 4;
            newnode.Tag = item;
            if (model.IsActiveConfiguration(item))
            {
                ShowProperActiveConfiguration(newnode);
            }
        }

        
        public void InsertItem(Microsoft.Build.BuildEngine.BuildItem item)
        {
            if (item.HasMetadata("Type"))
            {
                string type = item.GetMetadata("Type");
                switch (type)
                {
                    case "Config":
                        InsertConfigItem(item);
                        break;
                    case "Assembly":
                        InsertMappingAssembly(item);
                        break;
                    case "Mapping":
                        InsertMappingFile(item);
                        break;
                }
            }
        }

        private void InsertMappingFile(Microsoft.Build.BuildEngine.BuildItem item)
        {
            var newnode = mappingFilesNode.Nodes.Add(Path.GetFileName(item.Include));
            newnode.ToolTipText = item.Include;
            newnode.ImageIndex = newnode.SelectedImageIndex = 7;
            newnode.Tag = item;
        }
        public void BuildTreeBasicStructure()
        {
            root.Nodes.Clear();
            configNode = root.Nodes.Add("Configurations");
            configNode.ImageIndex = configNode.SelectedImageIndex = 1;
            mappingAssembliesNode = root.Nodes.Add("Mapping Assemblies");
            mappingAssembliesNode.ImageIndex = mappingAssembliesNode.SelectedImageIndex = 2;
            mappingFilesNode = root.Nodes.Add("Mapping Files");
            mappingFilesNode.ImageIndex = mappingFilesNode.SelectedImageIndex = 6;
           
        }

        private void contextMenuStripTree_Opening(object sender, CancelEventArgs e)
        {
            removeToolStripMenuItem.Enabled = treeProject.SelectedNode != null && treeProject.SelectedNode.Tag is MSBuild.BuildItem;
            setActiveToolStripMenuItem.Enabled = SelectedNodeIsConfiguration();
        }

        public bool SelectedNodeIsConfiguration()
        {
            MSBuild.BuildItem item = treeProject.SelectedNode.Tag as MSBuild.BuildItem;
            return item != null && item.HasMetadata("Type") &&
                item.GetMetadata("Type").Equals("Config");
        }
        public event EventHandler AddConfig;
        public event EventHandler AddMappingAssembly;
        private void addConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != AddConfig)
                AddConfig(this, EventArgs.Empty);
        }

        private void addAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != AddMappingAssembly)
                AddMappingAssembly(this, EventArgs.Empty);
        }

        public void RemoveSelectedNode()
        {
            if (null != treeProject.SelectedNode)
                treeProject.SelectedNode.Remove();
        }

        public MSBuild.BuildItem SelectedItem
        {
            get 
            {
                return treeProject.SelectedNode != null ? treeProject.SelectedNode.Tag as MSBuild.BuildItem : null;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != this.RemoveItem)
                RemoveItem(this,EventArgs.Empty);
        }
        public event EventHandler<OpenFileRequest> OpenFileRequest;
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (null != OpenFileRequest)
            {
                if (e.Node.Tag is MSBuild.BuildItem)
                {
                    OpenFileRequest(this, new OpenFileRequest() { FilePath = model.GetFilePathForItem(e.Node.Tag as MSBuild.BuildItem) });
                }
            }
        }

        public void UpdateItem(Microsoft.Build.BuildEngine.BuildItem item)
        {
            foreach (TreeNode n in configNode.Nodes)
            {
                if (n.Tag == item)
                {
                    n.Text = item.Include;
                    break;
                }
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != AddItem)
                AddItem(this, EventArgs.Empty);
        }

        private void setActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != ActivateConfiguration)
            {
                ActivateConfiguration(this, EventArgs.Empty);
                ShowProperActiveConfiguration(treeProject.SelectedNode);
            }
        }

        private void ShowProperActiveConfiguration(TreeNode active)
        {
            foreach (TreeNode n in configNode.Nodes)
            {
                if (n != active)
                    n.NodeFont = normalTreeFont;
                else
                    n.NodeFont = boldTreeFont;
            }
        }
    }
}

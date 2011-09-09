namespace NHibernate.Tool.WorkBench.Project
{
    partial class ProjectView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectView));
            this.treeProject = new System.Windows.Forms.TreeView();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListProject = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeProject
            // 
            this.treeProject.ContextMenuStrip = this.contextMenuStripTree;
            this.treeProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProject.ImageIndex = 0;
            this.treeProject.ImageList = this.imageListProject;
            this.treeProject.Location = new System.Drawing.Point(0, 0);
            this.treeProject.Name = "treeProject";
            this.treeProject.SelectedImageIndex = 0;
            this.treeProject.Size = new System.Drawing.Size(154, 243);
            this.treeProject.TabIndex = 0;
            this.treeProject.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.toolStripSeparator2,
            this.setActiveToolStripMenuItem,
            this.addConfigurationToolStripMenuItem,
            this.addAssemblyToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeToolStripMenuItem});
            this.contextMenuStripTree.Name = "contextMenuStripTree";
            this.contextMenuStripTree.Size = new System.Drawing.Size(174, 126);
            this.contextMenuStripTree.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTree_Opening);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addItemToolStripMenuItem.Image")));
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addItemToolStripMenuItem.Text = "Add &Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // setActiveToolStripMenuItem
            // 
            this.setActiveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setActiveToolStripMenuItem.Image")));
            this.setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
            this.setActiveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setActiveToolStripMenuItem.Text = "Set Active";
            this.setActiveToolStripMenuItem.Click += new System.EventHandler(this.setActiveToolStripMenuItem_Click);
            // 
            // addConfigurationToolStripMenuItem
            // 
            this.addConfigurationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addConfigurationToolStripMenuItem.Image")));
            this.addConfigurationToolStripMenuItem.Name = "addConfigurationToolStripMenuItem";
            this.addConfigurationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addConfigurationToolStripMenuItem.Text = "Add &Configuration";
            this.addConfigurationToolStripMenuItem.Click += new System.EventHandler(this.addConfigurationToolStripMenuItem_Click);
            // 
            // addAssemblyToolStripMenuItem
            // 
            this.addAssemblyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAssemblyToolStripMenuItem.Image")));
            this.addAssemblyToolStripMenuItem.Name = "addAssemblyToolStripMenuItem";
            this.addAssemblyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addAssemblyToolStripMenuItem.Text = "Add &Assembly";
            this.addAssemblyToolStripMenuItem.Click += new System.EventHandler(this.addAssemblyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // imageListProject
            // 
            this.imageListProject.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProject.ImageStream")));
            this.imageListProject.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProject.Images.SetKeyName(0, "applications-other.png");
            this.imageListProject.Images.SetKeyName(1, "document-properties.png");
            this.imageListProject.Images.SetKeyName(2, "12.png");
            this.imageListProject.Images.SetKeyName(3, "applications-system.png");
            this.imageListProject.Images.SetKeyName(4, "36.png");
            this.imageListProject.Images.SetKeyName(5, "38.png");
            this.imageListProject.Images.SetKeyName(6, "package-x-generic.png");
            this.imageListProject.Images.SetKeyName(7, "XMLFileHS.png");
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 243);
            this.Controls.Add(this.treeProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProjectView";
            this.Text = "Project";
            this.contextMenuStripTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeProject;
        private System.Windows.Forms.ImageList imageListProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;
        private System.Windows.Forms.ToolStripMenuItem addConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setActiveToolStripMenuItem;
    }
}

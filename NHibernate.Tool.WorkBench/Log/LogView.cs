// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using log4net.Core;
using System.Windows.Forms;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.Core.WireAttributes.UiHelpers;

namespace NHibernate.Tool.WorkBench.Log
{
    [PresenterView]
    class LogView:DockContent
    {
        private System.Windows.Forms.ImageList imageListMessages;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton messageButton;
        private System.Windows.Forms.ToolStripButton warningButton;
        private System.Windows.Forms.ToolStripButton errorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListView listViewMessages;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton debugButton;

        LogModel model;
        public LogView(MainForm form,LogModel model,ICommandRouter router)
        {
            InitializeComponent();
            router.PreExecute += new EventHandler(router_PreExecute);
            this.model = model;
            ShowHint = DockState.DockBottom;
            Show(form.DockPanel);
            listViewMessages.VirtualMode = true;
            model.ErrorsCountChanged += new EventHandler(model_ErrorsCountChanged);
            model.MessagesCountChanged += new EventHandler(model_MessagesCountChanged);
            model.WarningsCountChanged += new EventHandler(model_WarningsCountChanged);
            model.DebugsCountChanged += new EventHandler(model_DebugsCountChanged);
            listViewMessages.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(listView1_RetrieveVirtualItem);
            model_WarningsCountChanged(this, EventArgs.Empty);
            model_ErrorsCountChanged(this, EventArgs.Empty);
            model_MessagesCountChanged(this, EventArgs.Empty);
            model_DebugsCountChanged(this, EventArgs.Empty);
            warningButton.Click += new EventHandler(choicheButton_Click);
            messageButton.Click += new EventHandler(choicheButton_Click);
            errorButton.Click += new EventHandler(choicheButton_Click);
            debugButton.Click += new EventHandler(choicheButton_Click);
            SetVirtualSize();
        }

        void router_PreExecute(object sender, EventArgs e)
        {
            model.Clear();
            ClearCache();
        }

        void model_DebugsCountChanged(object sender, EventArgs e)
        {
             this.SafeInvoke(() =>
             {
                debugButton.Text = string.Concat(model.Debugs.ToString(), " ", "Debugs");
                SetVirtualSize();
                //Application.DoEvents();
             });
        }

        private void SetVirtualSize()
        {
           
            listViewMessages.VirtualListSize = (warningButton.Checked ? model.Warnings : 0)
                                        + (errorButton.Checked ? model.Errors : 0)
                                        + (messageButton.Checked ? model.Messages : 0)
                                        + (debugButton.Checked ? model.Debugs : 0)
                                        ;
        }

        void choicheButton_Click(object sender, EventArgs e)
        {
            ClearCache();
            SetVirtualSize();
        }
        IDictionary<int, LoggingEvent> cache = new Dictionary<int, LoggingEvent>();
        private void ClearCache()
        {
            cache.Clear();
        }

        void model_WarningsCountChanged(object sender, EventArgs e)
        {
            this.SafeInvoke(() =>
              {
                  warningButton.Text = string.Concat(model.Warnings.ToString(), " ", "Warnings");
                  SetVirtualSize();
                  //Application.DoEvents();
              });
        }

        void model_MessagesCountChanged(object sender, EventArgs e)
        {
            this.SafeInvoke(() =>
              {
                  messageButton.Text = string.Concat(model.Messages.ToString(), " ", "Messages");
                  SetVirtualSize();
                  //Application.DoEvents();
              });
        }

        void model_ErrorsCountChanged(object sender, EventArgs e)
        {
            this.SafeInvoke(() =>
              {
                  errorButton.Text = string.Concat(model.Errors.ToString(), " ", "Errors");
                  SetVirtualSize();
                  //Application.DoEvents();
              });
        }

        void listView1_RetrieveVirtualItem(object sender, System.Windows.Forms.RetrieveVirtualItemEventArgs e)
        {
            LoggingEvent le = Pick(e.ItemIndex);
            if (null != le)
            {
                e.Item = new ListViewItem();
                e.Item.Text = FormatMessage(le);
                e.Item.ImageIndex = ChooseImage(le);
                e.Item.SubItems.Add(new ListViewItem.ListViewSubItem());
                e.Item.SubItems[1].Text = le.LoggerName;
            }
        }

        private string FormatMessage(LoggingEvent le)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(le.RenderedMessage);
            if (null != le.ExceptionObject)
            {
                sb.Append(":");
                FormatMessage(le.ExceptionObject, sb);
            }
            return sb.ToString();
        }

        private void FormatMessage(Exception exception, StringBuilder sb)
        {
            sb.AppendLine(exception.Message);
            if (null != exception.InnerException)
                FormatMessage(exception.InnerException, sb);
            
        }

        private int ChooseImage(LoggingEvent le)
        {
            if (le.Level == Level.Debug)
                return 3;
            if (le.Level == Level.Error)
                return 2;
            if (le.Level == Level.Warn)
                return 1;
            if (le.Level == Level.Info)
                return 0;
            return -1;
        }

        private LoggingEvent Pick(int index)
        {
            if (!cache.ContainsKey(index))
            {
                var les = model.GetFromNth(index, 100, messageButton.Checked, warningButton.Checked, errorButton.Checked,debugButton.Checked);
                for (int i = 0; i < les.Count; ++i)
                {
                    cache[i + index] = les[i];
                }
            }
            if (cache.ContainsKey(index))
            {
                return cache[index];
            }
            return null;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imageListMessages = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.errorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.warningButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.messageButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.debugButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMessages
            // 
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMessages.FullRowSelect = true;
            this.listViewMessages.GridLines = true;
            this.listViewMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMessages.Location = new System.Drawing.Point(0, 25);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(605, 112);
            this.listViewMessages.SmallImageList = this.imageListMessages;
            this.listViewMessages.TabIndex = 0;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message";
            this.columnHeader1.Width = 378;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Logger";
            this.columnHeader2.Width = 122;
            // 
            // imageListMessages
            // 
            this.imageListMessages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMessages.ImageStream")));
            this.imageListMessages.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMessages.Images.SetKeyName(0, "dialog-information.png");
            this.imageListMessages.Images.SetKeyName(1, "dialog-warning.png");
            this.imageListMessages.Images.SetKeyName(2, "dialog-error.png");
            this.imageListMessages.Images.SetKeyName(3, "24.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorButton,
            this.toolStripSeparator1,
            this.warningButton,
            this.toolStripSeparator2,
            this.messageButton,
            this.toolStripSeparator3,
            this.debugButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // errorButton
            // 
            this.errorButton.Checked = true;
            this.errorButton.CheckOnClick = true;
            this.errorButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorButton.Image = ((System.Drawing.Image)(resources.GetObject("errorButton.Image")));
            this.errorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(57, 22);
            this.errorButton.Text = "Errors";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // warningButton
            // 
            this.warningButton.Checked = true;
            this.warningButton.CheckOnClick = true;
            this.warningButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warningButton.Image = ((System.Drawing.Image)(resources.GetObject("warningButton.Image")));
            this.warningButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.warningButton.Name = "warningButton";
            this.warningButton.Size = new System.Drawing.Size(77, 22);
            this.warningButton.Text = "Warnings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // messageButton
            // 
            this.messageButton.Checked = true;
            this.messageButton.CheckOnClick = true;
            this.messageButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.messageButton.Image = ((System.Drawing.Image)(resources.GetObject("messageButton.Image")));
            this.messageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(78, 22);
            this.messageButton.Text = "Messages";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // debugButton
            // 
            this.debugButton.Checked = true;
            this.debugButton.CheckOnClick = true;
            this.debugButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugButton.Image = ((System.Drawing.Image)(resources.GetObject("debugButton.Image")));
            this.debugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(62, 22);
            this.debugButton.Text = "Debug";
            // 
            // LogView
            // 
            this.ClientSize = new System.Drawing.Size(605, 137);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogView";
            this.Text = "Messages";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

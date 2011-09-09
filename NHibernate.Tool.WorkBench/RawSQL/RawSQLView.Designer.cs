namespace NHibernate.Tool.WorkBench.RawSQL
{
    partial class RawSQLView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawSQLView));
            this.labelErrorText = new System.Windows.Forms.TextBox();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.panelError = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErrorText
            // 
            this.labelErrorText.BackColor = System.Drawing.SystemColors.Info;
            this.labelErrorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErrorText.Location = new System.Drawing.Point(16, 0);
            this.labelErrorText.Margin = new System.Windows.Forms.Padding(10);
            this.labelErrorText.Multiline = true;
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(268, 56);
            this.labelErrorText.TabIndex = 1;
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.ReadOnly = true;
            this.textBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSQL.Size = new System.Drawing.Size(284, 206);
            this.textBoxSQL.TabIndex = 2;
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.SystemColors.Info;
            this.panelError.Controls.Add(this.labelErrorText);
            this.panelError.Controls.Add(this.pictureBox1);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelError.Location = new System.Drawing.Point(0, 206);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(284, 56);
            this.panelError.TabIndex = 3;
            this.panelError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RawSQLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.panelError);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RawSQLView";
            this.Text = "SQL Preview";
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labelErrorText;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

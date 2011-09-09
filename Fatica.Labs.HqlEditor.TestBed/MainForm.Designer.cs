namespace Fatica.Labs.HqlEditor.TestBed
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hqlEditor1 = new Fatica.Labs.HqlEditor.HqlEditor();
            this.SuspendLayout();
            // 
            // hqlEditor1
            // 
            this.hqlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hqlEditor1.IsReadOnly = false;
            this.hqlEditor1.Location = new System.Drawing.Point(0, 0);
            this.hqlEditor1.Name = "hqlEditor1";
            this.hqlEditor1.Size = new System.Drawing.Size(564, 123);
            this.hqlEditor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 123);
            this.Controls.Add(this.hqlEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Hql";
            this.ResumeLayout(false);

        }

        #endregion

        private HqlEditor hqlEditor1;
    }
}


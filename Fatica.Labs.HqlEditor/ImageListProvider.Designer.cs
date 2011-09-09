namespace Fatica.Labs.HqlEditor
{
    partial class ImageListProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageListProvider));
            this.imageListCompletion = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageListCompletion
            // 
            this.imageListCompletion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCompletion.ImageStream")));
            this.imageListCompletion.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCompletion.Images.SetKeyName(0, "05.png");
            this.imageListCompletion.Images.SetKeyName(1, "25.png");
            this.imageListCompletion.Images.SetKeyName(2, "41.png");
            this.imageListCompletion.Images.SetKeyName(3, "15.png");
            this.imageListCompletion.Images.SetKeyName(4, "23.png");
            this.imageListCompletion.Images.SetKeyName(5, "50.png");
            // 
            // ImageListProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImageListProvider";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListCompletion;
    }
}

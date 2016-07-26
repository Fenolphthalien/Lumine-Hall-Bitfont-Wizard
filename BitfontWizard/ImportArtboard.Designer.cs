namespace BitfontWizard
{
    partial class ImportArtboard
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
            this.artboard1 = new SpriteWizardControls.Artboard();
            this.SuspendLayout();
            // 
            // artboard1
            // 
            this.artboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artboard1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.artboard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.artboard1.image = null;
            this.artboard1.imageOffset = new System.Drawing.Point(30, 10);
            this.artboard1.Location = new System.Drawing.Point(12, 12);
            this.artboard1.maxScale = 400;
            this.artboard1.minScale = 50;
            this.artboard1.Name = "artboard1";
            this.artboard1.Size = new System.Drawing.Size(635, 240);
            this.artboard1.TabIndex = 0;
            // 
            // ImportArtboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 262);
            this.Controls.Add(this.artboard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImportArtboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportArtboard_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private SpriteWizardControls.Artboard artboard1;
    }
}
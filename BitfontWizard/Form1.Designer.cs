namespace BitfontWizard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.glyphGroupBox = new System.Windows.Forms.GroupBox();
            this.clearGlyphButton = new System.Windows.Forms.Button();
            this.editGlyphButton = new System.Windows.Forms.Button();
            this.moveGlyphDownButton = new System.Windows.Forms.Button();
            this.moveGlyphUpButton = new System.Windows.Forms.Button();
            this.removeGlyphButton = new System.Windows.Forms.Button();
            this.addGlyphButton = new System.Windows.Forms.Button();
            this.glyphListBox = new System.Windows.Forms.ListBox();
            this.bitfontGroupBox = new System.Windows.Forms.GroupBox();
            this.bitfontNameTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageOpenDialogue = new System.Windows.Forms.OpenFileDialog();
            this.imageImportDialogue = new System.Windows.Forms.OpenFileDialog();
            this.jsonSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.Bitfont2JasonOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.glyphGroupBox.SuspendLayout();
            this.bitfontGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // glyphGroupBox
            // 
            this.glyphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.glyphGroupBox.Controls.Add(this.clearGlyphButton);
            this.glyphGroupBox.Controls.Add(this.editGlyphButton);
            this.glyphGroupBox.Controls.Add(this.moveGlyphDownButton);
            this.glyphGroupBox.Controls.Add(this.moveGlyphUpButton);
            this.glyphGroupBox.Controls.Add(this.removeGlyphButton);
            this.glyphGroupBox.Controls.Add(this.addGlyphButton);
            this.glyphGroupBox.Controls.Add(this.glyphListBox);
            this.glyphGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.glyphGroupBox.Location = new System.Drawing.Point(12, 71);
            this.glyphGroupBox.Name = "glyphGroupBox";
            this.glyphGroupBox.Size = new System.Drawing.Size(333, 201);
            this.glyphGroupBox.TabIndex = 0;
            this.glyphGroupBox.TabStop = false;
            this.glyphGroupBox.Text = "Glyphs";
            // 
            // clearGlyphButton
            // 
            this.clearGlyphButton.Location = new System.Drawing.Point(218, 42);
            this.clearGlyphButton.Name = "clearGlyphButton";
            this.clearGlyphButton.Size = new System.Drawing.Size(109, 23);
            this.clearGlyphButton.TabIndex = 6;
            this.clearGlyphButton.Text = "Clear";
            this.clearGlyphButton.UseVisualStyleBackColor = true;
            this.clearGlyphButton.Click += new System.EventHandler(this.clearGlyphButton_Click);
            // 
            // editGlyphButton
            // 
            this.editGlyphButton.Location = new System.Drawing.Point(218, 19);
            this.editGlyphButton.Name = "editGlyphButton";
            this.editGlyphButton.Size = new System.Drawing.Size(109, 23);
            this.editGlyphButton.TabIndex = 5;
            this.editGlyphButton.Text = "Assign";
            this.editGlyphButton.UseVisualStyleBackColor = true;
            this.editGlyphButton.Click += new System.EventHandler(this.editGlyphButton_Click);
            // 
            // moveGlyphDownButton
            // 
            this.moveGlyphDownButton.Location = new System.Drawing.Point(218, 169);
            this.moveGlyphDownButton.Name = "moveGlyphDownButton";
            this.moveGlyphDownButton.Size = new System.Drawing.Size(109, 23);
            this.moveGlyphDownButton.TabIndex = 4;
            this.moveGlyphDownButton.Text = "Move Down";
            this.moveGlyphDownButton.UseVisualStyleBackColor = true;
            this.moveGlyphDownButton.Click += new System.EventHandler(this.moveGlyphDownButton_Click);
            // 
            // moveGlyphUpButton
            // 
            this.moveGlyphUpButton.Location = new System.Drawing.Point(218, 146);
            this.moveGlyphUpButton.Name = "moveGlyphUpButton";
            this.moveGlyphUpButton.Size = new System.Drawing.Size(109, 23);
            this.moveGlyphUpButton.TabIndex = 3;
            this.moveGlyphUpButton.Text = "Move Up";
            this.moveGlyphUpButton.UseVisualStyleBackColor = true;
            this.moveGlyphUpButton.Click += new System.EventHandler(this.moveGlyphUpButton_Click);
            // 
            // removeGlyphButton
            // 
            this.removeGlyphButton.Location = new System.Drawing.Point(218, 123);
            this.removeGlyphButton.Name = "removeGlyphButton";
            this.removeGlyphButton.Size = new System.Drawing.Size(109, 23);
            this.removeGlyphButton.TabIndex = 2;
            this.removeGlyphButton.Text = "Remove";
            this.removeGlyphButton.UseVisualStyleBackColor = true;
            this.removeGlyphButton.Click += new System.EventHandler(this.removeGlyphButton_Click);
            // 
            // addGlyphButton
            // 
            this.addGlyphButton.Location = new System.Drawing.Point(218, 100);
            this.addGlyphButton.Name = "addGlyphButton";
            this.addGlyphButton.Size = new System.Drawing.Size(109, 23);
            this.addGlyphButton.TabIndex = 1;
            this.addGlyphButton.Text = "Add";
            this.addGlyphButton.UseVisualStyleBackColor = true;
            this.addGlyphButton.Click += new System.EventHandler(this.addGlyphButton_Click);
            // 
            // glyphListBox
            // 
            this.glyphListBox.FormattingEnabled = true;
            this.glyphListBox.Location = new System.Drawing.Point(6, 19);
            this.glyphListBox.Name = "glyphListBox";
            this.glyphListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.glyphListBox.Size = new System.Drawing.Size(206, 173);
            this.glyphListBox.TabIndex = 0;
            // 
            // bitfontGroupBox
            // 
            this.bitfontGroupBox.Controls.Add(this.bitfontNameTextBox);
            this.bitfontGroupBox.Location = new System.Drawing.Point(12, 27);
            this.bitfontGroupBox.Name = "bitfontGroupBox";
            this.bitfontGroupBox.Size = new System.Drawing.Size(212, 38);
            this.bitfontGroupBox.TabIndex = 1;
            this.bitfontGroupBox.TabStop = false;
            this.bitfontGroupBox.Text = "Bitfont";
            // 
            // bitfontNameTextBox
            // 
            this.bitfontNameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.bitfontNameTextBox.Location = new System.Drawing.Point(6, 14);
            this.bitfontNameTextBox.Name = "bitfontNameTextBox";
            this.bitfontNameTextBox.ReadOnly = true;
            this.bitfontNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.bitfontNameTextBox.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(355, 24);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator4,
            this.exportMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(111, 6);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportMenuItem.Text = "Export";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.DefaultExt = "bitfont(*bitfont)|*.bitfont";
            this.mainOpenFileDialog.Filter = "Bitfont (*.bitfont)|*.bitfont";
            this.mainOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.mainOpenFileDialog_FileOk);
            // 
            // mainSaveFileDialog
            // 
            this.mainSaveFileDialog.DefaultExt = "bitfont(*bitfont)|*.bitfont";
            this.mainSaveFileDialog.Filter = "Bitfont (*.bitfont)|*.bitfont";
            this.mainSaveFileDialog.Title = "Save As:";
            this.mainSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.mainSaveFileDialog_FileOk);
            // 
            // imageOpenDialogue
            // 
            this.imageOpenDialogue.DefaultExt = "Bitmap (*.bmp)|*.bmp";
            this.imageOpenDialogue.Filter = "Bitmap (*.bmp)|*.bmp";
            this.imageOpenDialogue.Multiselect = true;
            this.imageOpenDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.imageOpenDialogue_FileOk);
            // 
            // imageImportDialogue
            // 
            this.imageImportDialogue.DefaultExt = "Bitmap (*.bmp)|*.bmp";
            this.imageImportDialogue.Filter = "Bitmap (*.bmp)|*.bmp";
            // 
            // jsonSaveDialog
            // 
            this.jsonSaveDialog.DefaultExt = "*.json";
            this.jsonSaveDialog.Filter = "\"UE4 JSON Data Table(*.json)\"|*.json";
            this.jsonSaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.jsonSaveDialog_FileOk);
            // 
            // Bitfont2JasonOpenDialog
            // 
            this.Bitfont2JasonOpenDialog.DefaultExt = "bitfont(*bitfont)|*.bitfont";
            this.Bitfont2JasonOpenDialog.DereferenceLinks = false;
            this.Bitfont2JasonOpenDialog.Filter = "Bitfont (*.bitfont)|*.bitfont";
            this.Bitfont2JasonOpenDialog.Multiselect = true;
            this.Bitfont2JasonOpenDialog.Title = "Files to Composite";
            this.Bitfont2JasonOpenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Bitfont2JasonOpenDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 285);
            this.Controls.Add(this.bitfontGroupBox);
            this.Controls.Add(this.glyphGroupBox);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitfont Wizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.glyphGroupBox.ResumeLayout(false);
            this.bitfontGroupBox.ResumeLayout(false);
            this.bitfontGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox glyphGroupBox;
        private System.Windows.Forms.ListBox glyphListBox;
        private System.Windows.Forms.Button moveGlyphDownButton;
        private System.Windows.Forms.Button moveGlyphUpButton;
        private System.Windows.Forms.Button removeGlyphButton;
        private System.Windows.Forms.Button addGlyphButton;
        private System.Windows.Forms.GroupBox bitfontGroupBox;
        private System.Windows.Forms.TextBox bitfontNameTextBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog mainSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog imageOpenDialogue;
        private System.Windows.Forms.Button editGlyphButton;
        private System.Windows.Forms.Button clearGlyphButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog imageImportDialogue;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog jsonSaveDialog;
        private System.Windows.Forms.OpenFileDialog Bitfont2JasonOpenDialog;



    }
}


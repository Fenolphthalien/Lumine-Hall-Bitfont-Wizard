namespace BitfontWizard
{
    partial class GlyphAssignForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.objectDataLabel = new System.Windows.Forms.Label();
            this.charInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.confirmButton.Location = new System.Drawing.Point(139, 95);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(220, 95);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.objectDataLabel);
            this.groupBox1.Controls.Add(this.charInputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associated Characters";
            // 
            // objectDataLabel
            // 
            this.objectDataLabel.AutoSize = true;
            this.objectDataLabel.Location = new System.Drawing.Point(176, 48);
            this.objectDataLabel.Name = "objectDataLabel";
            this.objectDataLabel.Size = new System.Drawing.Size(85, 13);
            this.objectDataLabel.TabIndex = 1;
            this.objectDataLabel.Text = "objectDataLabel";
            this.objectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charInputTextBox
            // 
            this.charInputTextBox.Location = new System.Drawing.Point(6, 19);
            this.charInputTextBox.Name = "charInputTextBox";
            this.charInputTextBox.Size = new System.Drawing.Size(419, 20);
            this.charInputTextBox.TabIndex = 0;
            this.charInputTextBox.TextChanged += new System.EventHandler(this.charInputTextBox_TextChanged);
            // 
            // GlyphAssignForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(455, 127);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GlyphAssignForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GlyphAssignForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox charInputTextBox;
        private System.Windows.Forms.Label objectDataLabel;
    }
}
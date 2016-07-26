using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitfontWizard
{
    public partial class GlyphAssignForm : Form
    {
        Bitglyph original, copy;

        public GlyphAssignForm(Bitglyph glyph)
        {
            original = glyph;
            copy = new Bitglyph(glyph);
            InitializeComponent();
            if (copy.associatedChars != null && copy.associatedChars.Length > 0)
                charInputTextBox.Text = copy.associatedChars;
            objectDataLabel.Text = copy.ToString();
        }

        private void charInputTextBox_TextChanged(object sender, EventArgs e)
        {
            copy.associatedChars = charInputTextBox.Text;
            objectDataLabel.Text = copy.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            original.associatedChars = copy.associatedChars;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

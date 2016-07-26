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
    public partial class GlyphMultiAssignForm : Form
    {
        bool exportable;
        Bitglyph[] glyphs;

        public GlyphMultiAssignForm(Bitglyph[] glyphs)
        {
            this.glyphs = glyphs;
            InitializeComponent();
            CrosscheckTextBoxes();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (exportable)
            {
                Run();
                this.Close();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startTextBox_TextChanged(object sender, EventArgs e)
        {
            exportable = CrosscheckTextBoxes();
        }

        private void endTextBox_TextChanged(object sender, EventArgs e)
        {
            exportable = CrosscheckTextBoxes();
        }

        private bool CrosscheckTextBoxes()
        {
            objectDataLabel.Text = string.Format("Start:{0}, End:{1}",StartString(),EndString());
            return startTextBox.Text.Length == endTextBox.Text.Length && startTextBox.Text.Length > 0 && endTextBox.Text.Length > 0;
        }

        private void Run()
        {
            short c, difference;
            for (int n = 0; n < startTextBox.Text.Length; n++)
            {
                if ((short)startTextBox.Text[n] > (short)endTextBox.Text[n])
                {
                    difference = (short)((short)startTextBox.Text[n] - (short)endTextBox.Text[n]);
                    for (short i = 0; i < (short)Math.Min(glyphs.Length, difference); i++)
                    {
                        c = System.Convert.ToInt16((byte)endTextBox.Text[n] - i);
                        glyphs[i].associatedChars += (char)c;
                    }
                }
                else
                {
                    difference = (short)((short)endTextBox.Text[n] - (short)startTextBox.Text[n]);
                    for (short i = 0; i < (short)Math.Min(glyphs.Length, difference); i++)
                    {
                        c = System.Convert.ToInt16((byte)startTextBox.Text[n] + i);
                        glyphs[i].associatedChars += (char)c;
                    }
                }
            }
        }

        private string StartString()
        {
            if (startTextBox.Text.Length > 0)
            {
                string s = "";
                for (int i = 0; i < startTextBox.Text.Length; i++)
                {
                    if (i == 0)
                    {
                        s += startTextBox.Text[i];
                    }
                    else
                    {
                        s += ", " + startTextBox.Text[i];
                    }
                }
                return s;
           }
           return "None.";
        }

        private string EndString()
        {
            if (endTextBox.Text.Length > 0)
            {
                string s = "";
                for (int i = 0; i < endTextBox.Text.Length; i++)
                {
                    if (i == 0)
                    {
                        s += endTextBox.Text[i];
                    }
                    else
                    {
                        s += ", " + endTextBox.Text[i];
                    }
                }
                return s;
            }
            return "None.";
        }

    }
}

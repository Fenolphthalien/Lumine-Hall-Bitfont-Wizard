using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BitfontWizard
{
    public partial class Form1 : Form
    {
        //=================================================
        // programmer defined fields.
        //=================================================
        Bitfont currentBitFont;
        GlyphAssignForm assignForm;
        GlyphMultiAssignForm multiAssignForm;
        ImportArtboard importArtboard;

        const string version = "1.00";

        string filePath = null;

        //=================================================
        // Constructor.
        //=================================================
        public Form1()
        {
            InitializeComponent();
        }

        //=================================================
        // Main form Events.
        //=================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
#if DISPLAY_SAVE_DIALOG_ON_QUIT
            if ((e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.FormOwnerClosing) && currentBitFont != null && !currentBitFont.saved)
            {
                DialogResult dialogResult = MessageBox.Show("Quit without saving?", "Unsaved file", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    saveToolStripMenuItem_Click(this, null);
                }
            }
#endif
        }

        //=================================================
        // Glyph editor events
        //=================================================
        private void addGlyphButton_Click(object sender, EventArgs e)
        {
            imageOpenDialogue.ShowDialog();
        }


        private void removeGlyphButton_Click(object sender, EventArgs e)
        {
            if (glyphListBox.SelectedItem != null && glyphListBox.SelectedItem is Bitglyph)
            {
                currentBitFont.Remove(glyphListBox.SelectedIndex);
                UpdateGlyphList();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void editGlyphButton_Click(object sender, EventArgs e)
        {
            if (glyphListBox.SelectedItem != null  && glyphListBox.SelectedItems != null && glyphListBox.SelectedItems[0] is Bitglyph)
            {
                if (assignForm == null && glyphListBox.SelectedItems.Count == 1)
                {
                    assignForm = new GlyphAssignForm((Bitglyph)glyphListBox.SelectedItems[0]);
                    assignForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.assignForm_Closed);
                    assignForm.Show();
                    assignForm.Activate();
                }
                else if (multiAssignForm == null && glyphListBox.SelectedItems.Count > 1)
                {
                    multiAssignForm = new GlyphMultiAssignForm(CastToBitGlyphArray(glyphListBox.SelectedItems));
                    multiAssignForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.multiAssignForm_Closed);
                    multiAssignForm.Show();
                    multiAssignForm.Activate();
                }
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void clearGlyphButton_Click(object sender, EventArgs e)
        {
            if (glyphListBox.SelectedItem != null && glyphListBox.SelectedItems != null && glyphListBox.SelectedItems[0] is Bitglyph)
            { 
                foreach(Bitglyph bitglyph in glyphListBox.SelectedItems)
                {
                    bitglyph.associatedChars = "";
                }
                UpdateGlyphList();
                UpdateFilePathLabel();
                currentBitFont.Edited();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void moveGlyphUpButton_Click(object sender, EventArgs e)
        {
            if (glyphListBox.SelectedItem != null && glyphListBox.SelectedItems != null && glyphListBox.SelectedItems[0] is Bitglyph)
            {
                for (int i = 0; i < glyphListBox.SelectedIndices.Count; i++)
                {
                    currentBitFont.MoveUp(glyphListBox.SelectedIndices[i]);
                }
                UpdateGlyphList();
                currentBitFont.Edited();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void moveGlyphDownButton_Click(object sender, EventArgs e)
        {
            if (glyphListBox.SelectedItem != null && glyphListBox.SelectedItems != null && glyphListBox.SelectedItems[0] is Bitglyph)
            {
                for (int i = glyphListBox.SelectedIndices.Count-1; i > -1; i--)
                {
                    currentBitFont.MoveDown(glyphListBox.SelectedIndices[i]);
                }
                UpdateGlyphList();
                currentBitFont.Edited();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        //=================================================
        // Menu strip events
        //=================================================
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentBitFont != null && filePath == null)
            {
                SaveAsDocument();
            }
            else if (currentBitFont != null && filePath != null)
            {
                SerialiseBitfontToFile(filePath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsDocument();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainOpenFileDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Current version : v{0}",version),"Version Info", MessageBoxButtons.OK);
        }

        //=================================================
        // Dialogue events.
        //=================================================
        private void mainSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dialogueRef = (SaveFileDialog)sender;
            if (dialogueRef != null && currentBitFont != null)
            {
                currentBitFont.name = Path.GetFileNameWithoutExtension(dialogueRef.FileName);
                filePath = dialogueRef.FileName;
                SerialiseBitfontToFile(filePath);
                UpdateFilePathLabel();
            }
        }


        private void mainOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialogueRef = (OpenFileDialog)sender;
            if (dialogueRef != null)
                LoadDocument(dialogueRef.FileName);
            UpdateFilePathLabel();
            UpdateGlyphList();
        }

        private void imageOpenDialogue_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialogueRef = (OpenFileDialog)sender;
            if (dialogueRef != null && currentBitFont != null)
            {
                int length = dialogueRef.FileNames.Length;
                for (int i = 0; i < length; i++)
                {
                    using (Bitmap bitmap = new Bitmap(dialogueRef.FileNames[i]))
                    {
                        currentBitFont.Add(new Bitglyph(bitmap));
                    }
                }
                UpdateGlyphList();
            }
        }

        //=================================================
        // Assign form events.
        //=================================================
        private void assignForm_Closed(object sender, FormClosedEventArgs e)
        {
            UpdateGlyphList();
            assignForm.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.assignForm_Closed);
            assignForm = null;
            currentBitFont.Edited();
            GC.Collect();
        }

        private void multiAssignForm_Closed(object sender, FormClosedEventArgs e)
        {
            UpdateGlyphList();
            multiAssignForm.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(this.multiAssignForm_Closed);
            multiAssignForm = null;
            currentBitFont.Edited();
            GC.Collect();
        }

        //=================================================
        // Private functions.
        //=================================================
        private void NewDocument()
        {
            currentBitFont = new Bitfont();
            filePath = null;
            UpdateFilePathLabel();
            UpdateGlyphList();
            GC.Collect();
        }

        private void SaveAsDocument()
        {
            mainSaveFileDialog.ShowDialog();
        }

        private void LoadDocument(string path)
        {
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                currentBitFont.Deserialise(br);
                br.Close();
            }
            filePath = path;
        }

        private void UpdateGlyphList()
        {
            if (currentBitFont != null)
            {
                glyphListBox.BeginUpdate();
                glyphListBox.Items.Clear();
                foreach (Bitglyph glyph in currentBitFont.glyphs)
                {
                    glyphListBox.Items.Add(glyph);
                }
                glyphListBox.EndUpdate();
            }
        }

        private void UpdateFilePathLabel()
        {
            if (filePath != null)
                bitfontNameTextBox.Text = filePath;
            else
                bitfontNameTextBox.Text = "Untitled";
        }

        private void SerialiseBitfontToFile(string path)
        {
            if (currentBitFont != null)
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    currentBitFont.Serialise(bw);
                    bw.Close();
                }
            }
        }

        private Bitglyph[] CastToBitGlyphArray(object[] objs)
        {
            List<Bitglyph> glyphL = new List<Bitglyph>();
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] is Bitglyph)
                {
                    glyphL.Add((Bitglyph)objs[i]);
                }
            }
            return glyphL.ToArray();
        }

        private Bitglyph[] CastToBitGlyphArray(ListBox.SelectedObjectCollection objs)
        {
            List<Bitglyph> glyphL = new List<Bitglyph>();
            for (int i = 0; i < objs.Count; i++)
            {
                if (objs[i] is Bitglyph)
                {
                    glyphL.Add((Bitglyph)objs[i]);
                }
            }
            return glyphL.ToArray();
        }
    }
}

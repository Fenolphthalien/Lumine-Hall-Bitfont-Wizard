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
    public partial class ImportArtboard : Form
    {
        public ImportArtboard(string path)
        {
            InitializeComponent();
            artboard1.LoadImage(path);
        }

        private void ImportArtboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    return;
                default:
                    return;
            }
        }

        public List<Bitglyph> Export()
        {
            List<Bitglyph> glyphList = new List<Bitglyph>();
            for(int i = 0; i < artboard1.sprites.Length; i++)
            {
                glyphList.Add(new Bitglyph(artboard1.sprites[i]));
            }
            return glyphList;
        }
    }
}

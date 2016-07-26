using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SpriteWizardControls;

namespace BitfontWizard
{
    public class Bitglyph : ISerialisable, IDisposable
    {
        #region serialisable
       
        public string associatedChars = "";
        public int width, height;

        bool[] m_bools;
        public bool[] bools { get { return m_bools; } }
       
        #endregion

        public Bitglyph(Bitmap bitmap)
        {
            width = bitmap.Width;
            height = bitmap.Height;
            m_bools = new bool[width * height];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (ValidColour(bitmap.GetPixel(col,row)))
                        m_bools[row * width + col] = true;
                }
            }
        }

        public Bitglyph(Bitglyph glyph)
        {
            width = glyph.width;
            height = glyph.height;
            m_bools = new bool[width * height];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    m_bools[row * width + col] = glyph.m_bools[row * width + col];
                }
            }
            associatedChars = glyph.associatedChars;
        }

        public Bitglyph(Sprite sprite)
        {
            width = sprite.width;
            height = sprite.height;
            m_bools = sprite.GetPixelThresholds(127);
        }

        public Bitglyph(System.IO.BinaryReader br)
        {
            Deserialise(br);
        }

        bool ValidColour(Color color)
        {
            int avgValue = (color.R * color.G * color.B) / 3;
            return avgValue <= 127;
        }

        public void Serialise(System.IO.BinaryWriter bw)
        { 
            //Write numberOfChars
            bw.Write(associatedChars);
            
            //Write width and height.
            bw.Write(width);
            bw.Write(height);

            //Write bool array length
            bw.Write(width * height);

            //Write bools
            for (int i = 0; i < m_bools.Length; i++)
            {
                bw.Write(m_bools[i]);
            }
        }

        public void Deserialise(System.IO.BinaryReader br)
        {
            //Write read number of chars and chars into array.
            associatedChars = br.ReadString();

            //Write width and height.
            width = br.ReadInt32();
            height = br.ReadInt32();
            m_bools = new bool[br.ReadInt32()];
            for (int i = 0; i < m_bools.Length; i++)
            {
                m_bools[i] = br.ReadBoolean();
            }
        }

        public override string ToString()
        {
            string s = string.Format("W:{0}, H:{1}, Characters: ",width,height);
            if (associatedChars.Length > 0)
            {
                for (int i = 0; i < associatedChars.Length; i++)
                {
                    if (i == 0)
                    {
                        s += associatedChars[i];
                    }
                    else
                    {
                        s += string.Format(", {0}", associatedChars[i]);
                    }
                }
            }
            else
            {
                s += "None.";
            }
            return s;
        }

        public void Dispose()
        {
            m_bools = null;
        }
    }
}

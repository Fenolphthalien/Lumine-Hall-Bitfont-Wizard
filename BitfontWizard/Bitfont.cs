using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitfontWizard
{
    public class Bitfont : ISerialisable, IDisposable
    {
        bool _saved = false;
        public bool saved { get { return _saved; } }

        #region serialisable
        public string name = "Untitled";

        public const string header = "Bfnt";

        public byte tracking = 1, spaceValue = 5;
        public Bitglyph[] glyphs { get { return glyphList.ToArray(); } }
        #endregion
        
        List<Bitglyph> glyphList = new List<Bitglyph>();

        public Bitfont(){}

        public void Add(Bitglyph glyph)
        {
            glyphList.Add(glyph);
            _saved = false;
        }

        public void Remove(int at)
        {
            glyphList[at] = null;
            for (int i = at ; i < glyphList.Count-1; i++)
            {
                glyphList[i] = glyphList[i+1];
            }
            if (glyphList[glyphList.Count - 1] == null || glyphList.Count-1 == at)
                glyphList.RemoveAt(glyphList.Count - 1);
            _saved = false;
        }

        public void MoveUp(int i)
        {
            if (i > 0)
            {
                Bitglyph origin = glyphs[i - 1];
                glyphList[i - 1] = glyphs[i];
                glyphList[i] = origin;
                _saved = false;
            }
        }

        public void MoveDown(int i)
        {
            if (i < glyphList.Count)
            {
                Bitglyph origin = glyphs[i + 1];
                glyphs[i + 1] = glyphs[i];
                glyphs[i] = origin;
                _saved = false;
            }
        }

        public void Edited()
        {
            _saved = false;
        }

        public void Serialise(System.IO.BinaryWriter bw)
        {
            //Write Header
            bw.Write(header.ToCharArray());

            //Write name length
            char[] nameArray = name.ToCharArray();
            bw.Write(nameArray.Length);
            bw.Write(nameArray);

            //Write tracking and spaceValue
            bw.Write(tracking);
            bw.Write(spaceValue);

            //Write glyphCount
            bw.Write(glyphs.Length);

            for (int i = 0; i < glyphs.Length; i++)
            {
                glyphList[i].Serialise(bw);
            }
            _saved = true;
        }

        public void Deserialise(System.IO.BinaryReader br)
        { 
            //Read header
            string inHeader = new string(br.ReadChars(4));
            if (inHeader == header)
            {
                //Read name length
                int nameLength = br.ReadInt32();
                name = new string(br.ReadChars(nameLength));

                //Read tracking and spaceValue
                tracking = br.ReadByte();
                spaceValue = br.ReadByte();

                //Read glyphCount
                int noOfGlyphs = br.ReadInt32();
                glyphList = new List<Bitglyph>();

                //Read glyphs
                for (int i = 0; i < noOfGlyphs; i++)
                {
                    glyphList.Add(new Bitglyph(br));
                }
                _saved = true;
            }
            else
            {
                return;
            }
        }

        public void Dispose()
        {
            for (int i = 0; i < glyphList.Count; i++)
            {
                glyphList[i].Dispose();
            }
            glyphList = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitfontWizard
{
    namespace JSONExport
    {
        public class Bitfont2JSON : IDisposable, IRequireCustomJSON<int, bool>
        {
            public byte tracking = 1, spaceValue = 5;
            public int glyphCount, maxHeight;
            public Bitglyph_t[] bitglyphs;

            public Bitfont2JSON(Bitfont bitfont)
            {
                tracking = bitfont.tracking;
                spaceValue = bitfont.spaceValue;
                glyphCount = bitfont.glyphs.Length;

                bitglyphs = new Bitglyph_t[glyphCount];
                for (int i = 0; i < glyphCount; i++)
                {
                    bitglyphs[i] = new Bitglyph_t(bitfont.glyphs[i]);
                    maxHeight = maxHeight < bitfont.glyphs[i].height ? 
                        bitfont.glyphs[i].height : maxHeight;
                }
            }

            public void Dispose()
            {
                for (int i = 0; i < glyphCount; i++)
                {
                    bitglyphs[i].Dispose();
                }
                Array.Clear(bitglyphs, 0, glyphCount);
                bitglyphs = null;
            }

            public string ParseIntoJSON(int param1, bool param2)
            {

                string s = "{";

                s += string.Format("\"Name\":\"{0}\",\n",param1);
                s += string.Format("\"EntryID\":\"{0}\",\n", param1);
                s += string.Format("\"tracking\":{0},\n", tracking);
                s += string.Format("\"spaceValue\":{0},\n", spaceValue);
                s += string.Format("\"glyphCount\":{0},\n", glyphCount);
                s += string.Format("\"maxHeight\":{0},\n", maxHeight);
                s += "\"bitglyphs\":\n";

                string arrayParenthesis = "[\n]\n",array = string.Empty;
                for (int i = 0; i < bitglyphs.Length; i++)
                { 
                    array += bitglyphs[i].ParseIntoJSON();
                    if(i < bitglyphs.Length-1)
                        array += ",\n";
                }
                arrayParenthesis = arrayParenthesis.Insert(2,array);

                s += arrayParenthesis;
                s += "}";
                if (param2)
                    s += ",";

                return s;
            }
        }

        public struct Bitglyph_t : IDisposable, IRequireCustomJSON
        {
            public int width, height;
            public string assocChars;

            public bool[] bitArray;

            public Bitglyph_t(Bitglyph glyph)
            {
                width = glyph.width;
                height = glyph.height;
                assocChars = string.Empty;
                for (int i = 0; i < glyph.associatedChars.Length; i++ )
                {
                    assocChars += glyph.associatedChars[i];
                }
                int arrayLength = glyph.bools.Length;
                bitArray = new bool[arrayLength];
                Array.Copy(glyph.bools, bitArray, arrayLength);
            }

            public void Dispose()
            {
                int arrayLength = bitArray.Length;
                Array.Clear(bitArray, 0, arrayLength);
                assocChars = string.Empty;
                assocChars = null; 
                bitArray = null;
            }

            public string ParseIntoJSON()
            {
                const string json = "\"(width={0}, height={1}, assocChars =\\\"{2}\\\",bitArray=";
                string arrayParenthesis = "()", array = string.Empty;
                string s = string.Format(json,width,height,assocChars);
                for (int i = 0; i < bitArray.Length; i++)
                {
                    array += bitArray[i] ? "true" : "false";
                    if (i < bitArray.Length - 1)
                        array += ",";
                }
                arrayParenthesis = arrayParenthesis.Insert(1, array);
                s += arrayParenthesis;
                s += ")\"";
                return s;
            }
        }
   }
}

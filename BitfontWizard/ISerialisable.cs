using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitfontWizard
{
    public interface ISerialisable
    {
        void Serialise(System.IO.BinaryWriter bw);
        void Deserialise(System.IO.BinaryReader br);
    }
}

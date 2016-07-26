using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitfontWizard
{
    public interface IRequireCustomJSON
    {
        string ParseIntoJSON();
    }

    public interface IRequireCustomJSON<T>
    {
        string ParseIntoJSON(T param);
    }

    public interface IRequireCustomJSON<T1,T2>
    {
        string ParseIntoJSON(T1 param1, T2 param2);
    }
}

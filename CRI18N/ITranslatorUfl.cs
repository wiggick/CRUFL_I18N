using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CRUFL_I18N
{
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("734648C4-122E-43F1-82E4-10EB0244AFC1")]
    public interface ITranslatorUfl
    {
        string GetTranslation(string key, string json);
    }
}

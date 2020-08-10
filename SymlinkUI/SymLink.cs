using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SymlinkUI
{
    static class SymLink
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTiargetFileName, E_SymLink dwFlags);
        
        public static bool CreateSymLink(string lpSymlinkFileName, string lpTiargetFileName, E_SymLink dwFlags)
        {
            return CreateSymbolicLink(lpSymlinkFileName,lpTiargetFileName,dwFlags);
        }
    }

}

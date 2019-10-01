using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes.Model
{
    public static class ListaBranca
    {
        private static Regex GetListaBranca = new Regex(
     @"[a-z][a-z][a-z]-[0-9][0-9][0-9][0-9]",
     RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

        public static bool ValidaPlaca(this string code)
        {
            return !GetListaBranca.Match(code).Success;
        }
    }

}

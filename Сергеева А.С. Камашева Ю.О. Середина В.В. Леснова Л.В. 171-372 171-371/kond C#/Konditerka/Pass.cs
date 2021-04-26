using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Konditerka
{
    public class Pass
    {
        public bool isTrue(string pass)
        {


            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasSpecialSymbols = new Regex(@"[!@#$%^]");
            var hasMinimum6Chars = new Regex(@".{6,}");


            var isValidated =
            hasNumber.IsMatch(pass) &&
            hasUpperChar.IsMatch(pass) &&
            hasSpecialSymbols.IsMatch(pass) &&
            hasMinimum6Chars.IsMatch(pass);

            if (!isValidated)
            {
                return false;
            }
            else
            {
                return true;
            }
            {
            }
        }
    }
}
    


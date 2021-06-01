using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NewBank.Common
{
    public static class Utilities
    {
        // clean string to remove digit at the begining
        public static string RemoveDigitFromStart(string val)
        {
           
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 48 && strCode <= 57)
            {
                return val.Substring(1);
            }

            return val;
        }

        // Change first character to caps
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                return (char)strCaps + val.Substring(1);
            }

            return val;
        }




        //validate email
        public static bool ValidateEmail(string val)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(val);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}

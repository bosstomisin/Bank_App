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
            //if (val.Length == 0)
            //{
            //    throw new 
            //}
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


        // Generate hash
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }


        // compare password hash
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // validate email
        //public static bool IsEmailValid(string email)
        //{
        //    if (email.Contains('@'))
        //    {
        //        int len = email.Substring(email.LastIndexOf('.')).Length;
        //        if (len >= 3 && len <= 4)
        //            return true;
        //    }
        //    return false;
        //}

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


        #region PRINT TABLE UTILITY CODE
        public static void PrintLine(int widthOfTable)
        {
            Console.WriteLine(new string('-', widthOfTable));
        }

        public static void PrintRow(int widthOfTable, params string[] columns)
        {
            int width = (widthOfTable - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += CenterText(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string CenterText(string column, int width)
        {
            column = column.Length > width ? column.Substring(0, width - 3) + "..." : column;

            if (!string.IsNullOrEmpty(column))
            {
                return column.PadRight(width - (width - column.Length) / 2).PadLeft(width);
            }
            else
            {
                return new string(' ', width);
            }
        }

        #endregion

        public static void DisplayCenteredText(string text, bool showLine)
        {
            Console.Write(new string(' ', ((Console.WindowWidth / 2) - ($"{text}".Length / 2))));
            Console.WriteLine($"{text}");
            if (showLine)
                Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine();
        }
    }
}

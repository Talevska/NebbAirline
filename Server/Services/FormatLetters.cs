using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public class FormatLetters
    {
        public static string FirstCharToUpper(string myString)
        {
            string first = myString.First().ToString().ToUpper();
            return first + myString.Substring(1);
        }

        public static string CodeCharsToUpper(string myString)
        {
            string first = myString.First().ToString().ToUpper();
            string second = myString.Substring(1).First().ToString().ToUpper();
            return first + second + myString.Substring(2);
        }
    }
}

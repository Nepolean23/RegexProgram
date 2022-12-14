using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Program
{
    public class UC_2_LastName
    {
        public static string Regex_Rule = "[A-Za-z]{3,}";

        public bool ValidatePincode(string inputstring)
        {
            return Regex.IsMatch(inputstring, Regex_Rule);
        }


    }
}

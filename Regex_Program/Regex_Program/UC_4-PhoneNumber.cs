using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Program
{
    public class UC_4_PhoneNumber
    {
        public static string Regex_rule = "^[1-9]{2}[ ][1-9]+$";

        public bool ValidatePincode(string inputstring)
        {
            return Regex.IsMatch(inputstring, Regex_rule);
        }

    }
}

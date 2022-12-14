using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Program
{
    public class UC_3_Email_Id
    {
        public static  string Regex_rule = "^[A-Za-z]+[.]([A-Za-z]+)?[@][A-Za-z]+[.][A-Za-z]+[.]([A-Za-z]+)?$";

        public bool ValidatePincode(string inputstring)
        {
                return Regex.IsMatch(inputstring, Regex_rule);
        }
    }
}

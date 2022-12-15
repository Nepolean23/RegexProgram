using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Program
{
     public class UC_5_PasswordCreating
    {
        public const string Regex_rule = "(^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,})$";

        public bool ValidatePincode(string inputstring)
        {
           return Regex.IsMatch(inputstring, Regex_rule);
        }

        
    }
}

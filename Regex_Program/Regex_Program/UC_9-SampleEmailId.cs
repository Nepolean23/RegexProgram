using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Program
{
    public class UC_9_SampleEmailId
    {
        public static string Regex_rule = "^[a-z]{3}([.+-@])?([a-z]+)?([0-9]+)?([@])?([a-z]+)?[.][a-z]{3}([,.])?([a-z]+)?$";

        public bool ValidatePincode(string inputstring)
        {
            return Regex.IsMatch(inputstring,Regex_rule);
        }

    }
}

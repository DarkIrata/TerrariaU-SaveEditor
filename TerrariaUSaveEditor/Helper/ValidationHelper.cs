using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TerrariaUSaveEditor
{
    public static class ValidationHelper
    {
        public static bool IsNameValid(string name, out string error)
        {
            error = "OK";
            if (string.IsNullOrEmpty(name))
            {
                error = "Name can't be empty.";
                return false;
            }

            if (name.Length > 16)
            {
                error = "Name is longer then 16 chars.";
                return false;
            }

            if (!Regex.Match(name, @"^[a-zA-Z 0-9\?\!\*]*$").Success)
            {
                error = "Only a-z, A-Z, 0-9, ?, * and ! are allowed chars.";
                //error = $"Only a-z, A-Z, 0-9, ?, * and !{Environment.NewLine} are allowed chars.";
                return false;
            }

            return true;
        }

        public static bool IsNameValid(string name)
        {
            string error = string.Empty;
            return IsNameValid(name, out error);
        }
    }
}

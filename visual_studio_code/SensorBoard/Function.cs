using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SensorBoard
{
    class Function
    {
        internal static string slugify(string name)
        {
            return Regex.Replace(name, "[^a-z0-9\\._\\s]", "", RegexOptions.IgnoreCase);
        }

        internal static bool IsValidEmailAddress(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(s) && !s.EndsWith(".");
            }
        }
    }
}

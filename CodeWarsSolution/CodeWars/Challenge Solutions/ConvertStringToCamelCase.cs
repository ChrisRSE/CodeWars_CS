using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public class ConvertStringToCamelCase
    {
        public static string Solution(String str)
        {
            return Char.ToLowerInvariant(str[0]) + str.Substring(1).Replace("_", string.Empty).Replace(" ", string.Empty).Replace("-", string.Empty);
        }
    }
}

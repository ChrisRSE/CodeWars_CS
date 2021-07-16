using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public class DetectPangram
    {
        public static bool Solution(String str)
        {
            return str.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
        }
    }
}

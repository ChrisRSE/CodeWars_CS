using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public class Switcheroo
    {
        public static string SwitcherooMethod(string x)
        {
            ////Standard Solution
            //string newString = "";
            //foreach (var c in x)
            //{
            //    if (c == 'a')
            //        newString += 'b';
            //    else if (c == 'b')
            //        newString += 'a';
            //    else
            //        newString += c;
            //}
            //return newString;

            // One line
            return x.Replace('a', 'x').Replace('b', 'a').Replace('x','b');
        }
    }
}

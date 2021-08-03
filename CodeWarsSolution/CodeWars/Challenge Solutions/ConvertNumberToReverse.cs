using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public static class ConvertNumberToReverse
    {
        public static long[] Digitize(long n)
        {
            //// Initial Solution

            //var stringArr = n.ToString().ToCharArray();
            //var longArr = new long[stringArr.Length];
            //int j = 0;
            //for(int i = longArr.Length - 1; i >= 0; i--)
            //{
            //    longArr[j++] = Convert.ToInt32(stringArr[i]);
            //}

            //return longArr;

            // One Line Solution >:)
            return n.ToString().Reverse().Select(n => Convert.ToInt64(n.ToString())).ToArray();
        }
    }
}

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
            var stringArr = n.ToString().ToCharArray();
            var longArr = new long[stringArr.Length];
            int j = 0;
            for(int i = longArr.Length - 1; i >= 0; i--)
            {
                longArr[j++] = stringArr[i] - 48;
            }

            return longArr;
        }
    }
}

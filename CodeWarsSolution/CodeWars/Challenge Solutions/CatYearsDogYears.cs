using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public class CatYearsDogYears
    {
        public static int[] humanYearsCatYearsDogYears(int y)
        {
            //// LONG SOLUTION
            //int cat = 0;
            //int dog = 0;

            //if (y == 1)
            //{
            //    cat = 15;
            //    dog = 15;
            //}
            //else if (y == 2)
            //{
            //    cat = 24;
            //    dog = 24;
            //}
            //else
            //{
            //    cat = (y -2) * 4 +24;
            //    dog = (y - 2) * 5 + 24;
            //}
            //return new int[] { y, cat, dog };

            // One Line Solution
            return y == 1 ? new int[] { y, 15, 15 } : y == 2 ?
                new int[] { y, 24, 24 } : new int[] { y, (y - 2) * 4 + 24, (y - 2) * 5 + 24 };
        }
    }
}

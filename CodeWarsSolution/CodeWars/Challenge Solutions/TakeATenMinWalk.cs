using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenge_Solutions
{
    public class TakeATenMinWalk
    {
        public static bool Solution(String[] arr)
        {
            int yAxis = 0, xAxis = 0;
            foreach (var str in arr)
            {
                switch (str)
                {
                    case ("n"):
                        xAxis++;
                        break;
                    case ("s"):
                        xAxis--;
                        break;
                    case ("e"):
                        yAxis++;
                        break;
                    case ("w"):
                        yAxis--;
                        break;
                }
            }
            if (yAxis == 0 && xAxis == 0 && arr.Length == 10)
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_202
    {
        public static bool IsHappy(int n)
        {
            int i = n;
            HashSet<int> set = new HashSet<int>();
            while (true)
            {
                int result = i;
                var fuck = 0;
                while (result > 0)
                {
                    var k = result % 10;
                    result = result / 10;
                    fuck = fuck + (int)Math.Pow(k, 2);
                }

                if (fuck == 1)
                {
                    return true;
                }
                if (set.Contains(fuck))
                {
                    return false;
                }
                else
                {
                    set.Add(fuck);
                    i = fuck;
                }

            }

        }
    }
}

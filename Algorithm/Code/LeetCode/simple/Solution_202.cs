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
                var Func = 0;
                while (result > 0)
                {
                    var k = result % 10;
                    result = result / 10;
                    Func = Func + (int)Math.Pow(k, 2);
                }

                if (Func == 1)
                {
                    return true;
                }
                if (set.Contains(Func))
                {
                    return false;
                }
                else
                {
                    set.Add(Func);
                    i = Func;
                }

            }

        }
    }
}

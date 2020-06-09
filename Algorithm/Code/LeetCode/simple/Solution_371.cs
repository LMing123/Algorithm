using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_371
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int c = (a & b) << 1;
                a = a ^ b;
                b = c;
            }
            return a;
        }
    }
}

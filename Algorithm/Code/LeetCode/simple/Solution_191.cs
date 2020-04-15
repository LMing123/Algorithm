using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_191
    {
        public static int HammingWeight(uint n)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & (uint)1 << i) == (uint)1 << i) result++;
            }
            return result;
        }
    }
}

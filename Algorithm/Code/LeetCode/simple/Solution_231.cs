using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_231
    {
        public static bool IsPowerOfTwo(int n)
        {
            int i = 1;
            int count = 0;
            while (n >= i)
            {
                if (count > 31) return false;
                if (n == i) return true;
                i <<= 1;
                count++;
            }
            return false;
        }
    }
}

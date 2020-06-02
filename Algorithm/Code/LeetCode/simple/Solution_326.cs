using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_326
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            while(n!=0)
            {
                if (n % 3 != 0) return false;
                n = n / 3;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_342
    {
        public bool IsPowerOfFour(int num)
        {
            int i;
            for (int j = 0; j <= 32; j++)
            {
                i = 1 << (j * 2);
                if (i > num) break;
                if (i == (i | num)) return true;
            }
            return false;
        }
    }
}

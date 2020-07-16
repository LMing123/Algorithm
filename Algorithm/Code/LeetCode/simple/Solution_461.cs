using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_461
    {
        public int HammingDistance(int x, int y)
        {
            int result = 0;
            uint u = (uint)(x ^ y);
            for (int i = 0; i < 32; i++)
            {
                uint mask = (uint)1 << i;
                if ((mask & u) != 0) result++;
            }
            return result;
        }
    }
}

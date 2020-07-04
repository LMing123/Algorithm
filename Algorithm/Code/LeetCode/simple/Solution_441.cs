using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_441
    {
        public int ArrangeCoins(int n)
        {
            return (int)(Math.Sqrt(2 * (double)n + 0.25) - 0.5);
            // if(n==0) return 0;
            //for(int i=1; ;i++)
            //{
            //    int result = ((1 + i) * i) / 2;
            //    int j = i + 1;
            //    int tem= ((1 + j) * j) / 2;
            //    if (result <= n && tem > n) return i;
            //}

        }
    }
}

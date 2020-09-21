using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_598
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            if (ops.Length == 0) return m * n;
            int firstDimension = int.MaxValue;
            int secondDimension = int.MaxValue;
            for(int i=0;i<ops.Length;i++)
            {
                firstDimension= Math.Min(ops[i][0], firstDimension);
                secondDimension = Math.Min(ops[i][1], secondDimension);
            }

            return firstDimension * secondDimension;
        }
    }
}

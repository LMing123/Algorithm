using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 69. x 的平方根
    /// </summary>
    class Solution_69
    {
        public static int Fuck(int x)
        {
            double a = 1, acc = 0.1;
            double result = (x / a + a) / 2;
            while(Math.Abs(result*result-x)>acc)
                result = (x / result + result) / 2;
            return (int)result;
        }
    }
}

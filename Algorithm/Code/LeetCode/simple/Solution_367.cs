using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_367
    {

        public bool IsPerfectSquare(int num)
        {
            if (num < 2) return true;
            long left = 2;
            long right = num / 2;
            while (left <= right)
            {
                long x = left + (right - left) / 2;
                long result = x * x;
                if (result == num) return true;
                if (result < num) left = x + 1;
                else right = x - 1;
            }
            return false;
        }
    }
}

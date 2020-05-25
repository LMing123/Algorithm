using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_263
    {
        public bool IsUgly(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;

            while (num % 2 == 0) num = num / 2;
            while (num % 3 == 0) num = num / 3;
            while (num % 5 == 0) num = num / 5;

            if (num == 1) return true;
            return false;
        }
    }
}

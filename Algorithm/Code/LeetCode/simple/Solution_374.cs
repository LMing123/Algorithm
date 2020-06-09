using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_374
    {
        public int GuessNumber(int n)
        {
            int min = 1;
            int max = n;
            int num = 0;
            while (min <= max)
            {
                num = min + (max - min) / 2;
                var result = guess(num);
                if (result == 0) return num;
                else if (result == 1) min = num + 1;
                else max = num - 1;
            }
            return num;
        }
        public int guess(int num)
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_258
    {
        public static int AddDigits(int num)
        {
            return (num - 1) % 9 + 1;

        }
        public static int AddDigits1(int num)
        {
            int result;
            do
            {
                result = 0;
                while (num > 0)
                {
                    result += num % 10;
                    num /= 10;
                }
                num = result;
              
            } while (result >= 10);
            return result;
        }
    }
}

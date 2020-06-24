using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_409
    {
        public static int LongestPalindrome(string s)
        {
            int[] list = new int[58];
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                list[s[i] - 'A'] += 1;
                if (list[s[i] - 'A'] % 2 == 0)
                {
                    result += 2;
                }
            }
            return result == s.Length ? result : result + 1;
        }
    }
}

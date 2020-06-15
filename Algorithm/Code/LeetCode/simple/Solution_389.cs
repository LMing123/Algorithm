using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_389
    {
        public char FindTheDifference(string s, string t)
        {
            int[] list = new int[26];
            for(int index=0;index<s.Length;index++)
            {
                list[s[index] - 'a']++;
            }

            for(int index=0;index<t.Length;index++)
            {
                list[t[index] - 'a']--;
                if (list[t[index] - 'a'] < 0) return t[index];
            }
            return '0';
        }
    }
}

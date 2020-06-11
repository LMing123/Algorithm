using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_387
    {
        public int FirstUniqChar(string s)
        {
            if (s.Length == 0) return -1;
            int[] list = new int[26];
            for(int index=0;index<s.Length;index++)
            {
                int value = s[index] - 'a';
                list[value]++;
            }
            for (int index = 0; index < s.Length; index++)
            {
                int value = s[index] - 'a';
                if (list[value] == 1) return index;
            }
            return -1;
        }
    }
}

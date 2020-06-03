using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_344
    {
        public void ReverseString(ref char[] s)
        {
            if (s.Length == 0) return;
            int i = 0;
            int j = s.Length - 1;
            char c;
            while(i<j)
            {
                c = s[i];
                s[i] = s[j];
                s[j] = c;
                i++;j--;
            }
        }
    }
}

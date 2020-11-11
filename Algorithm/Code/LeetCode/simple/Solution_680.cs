using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_680
    {
        public bool ValidPalindrome(string s)
        {
            if (s.Length == 0) return false;
            return Helper(ref s, 0, s.Length - 1, true);
        }


        public static bool Helper(ref string s ,int start, int end,bool canRemove)
        {
            int begin = start;
            while (begin < end)
            {
                if (s[begin] == s[end])
                {
                    begin++;
                    end--;
                }
                else if (canRemove)
                {
                    return Helper(ref s, begin + 1, end, false)||Helper(ref s,begin,end-1,false);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

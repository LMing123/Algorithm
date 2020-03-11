using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_125
    {
        public static bool IsPalindrome(string s)
        {
            bool result = true;
            
            if (s.Length == 0 || string.IsNullOrEmpty(s)) return result;
            var p = s.AsSpan();
            int i = 0;
            int j = s.Length - 1;
            while(i!=j)
            {
                if (i > j) break;
                char tem1 =char.ToLower( p[i]);
                char tem2 = char.ToLower( p[j]);
                if(!char.IsLetterOrDigit(tem1))
                {
                    i++;
                    continue;
                }
                if(!char.IsLetterOrDigit(tem2))
                {
                    j--;
                    continue;
                }
                if (tem1 != tem2) return false;
                i++;
                j--;

            }
            return result;
        }
    }
}

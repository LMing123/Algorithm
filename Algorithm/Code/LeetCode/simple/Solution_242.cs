using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            HashSet<char> vs = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (vs.Contains(s[i])) continue;
                vs.Add(s[i]);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!vs.Contains(t[i])) return false;
            }

            int result1 = 0;
            int result2 = 0;
            int length = s.Length > t.Length ? s.Length : t.Length;
            for(int i=0;i<length;i++)
            {
                result1 += s.Length > i ? s[i] : 0;
                result2 += t.Length > i ? t[i] : 0;
            }
            return result1 == result2 ? true:false;
        }
    }
}

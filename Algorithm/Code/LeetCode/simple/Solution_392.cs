using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0 && t.Length != 0) return true;
            if (s.Length != 0 && t.Length == 0) return false;
            if (s.Length == 0 && t.Length == 0) return true;
            int index = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[index] == t[i]) index++;
                if (index >= s.Length) return true;
            }
            return false;
        }
    }
}

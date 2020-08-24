using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_521
    {
        public int FindLUSlength(string a, string b)
        {
            if (a.Length != b.Length) return Math.Max(a.Length, b.Length);
            if (a == b) return -1;
            return a.Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_434
    {
        public static int CountSegments(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return 0;
            var i =s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            return i;
        }
    }
}

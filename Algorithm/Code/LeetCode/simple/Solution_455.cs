using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_455
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int i = g.Length - 1;
            int j = s.Length - 1;
            int result = 0;
            while(i>=0&&j>=0)
            {
                if(s[j]>=g[i])
                {
                    i--;j--;result++;
                }
                else
                {
                    i--;
                }
            }
            return result;

        }
    }
}

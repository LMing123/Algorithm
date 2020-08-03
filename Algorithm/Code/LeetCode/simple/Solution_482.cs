using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_482
    {
        public static string LicenseKeyFormatting(string S, int K)
        {
            var sb = new StringBuilder(S.Length);
            char stack = '-';
            int step = 0;
            for(int i=S.Length-1;i>=0;i--)
            {
                if (S[i] == '-') continue;
                if (step >= K)
                {
                    step = 0;
                    sb.Append(stack);
                }
               
                sb.Append(char.ToUpper( S[i]));
                step++;
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}

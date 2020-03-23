using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_171
    {
        public static int TitleToNumber(string s)
        {
            int length = s.Length;
            char a = '@';
            int result = 0;
            int j = 0;
            for(int i=length-1;i>=0;i--,j++)
            {
               result+= (int)Math.Pow(26, j)*(s[i]-a);

            }
            return result;
        }
    }
}

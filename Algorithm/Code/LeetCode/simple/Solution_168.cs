using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_168
    {
        public static string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            char a = 'A';

            while (n > 0)
            {
                var i = n % 26;
                if (i == 0)
                {
                    sb.Insert(0, 'Z');
                    n = n - 26;
                }
                else
                {
                    sb.Insert(0, char.ConvertFromUtf32(a + i - 1));
                }

                n = n / 26;             

            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 38. 报数
    /// </summary>
    public class Solution_38
    {
        public static string Fuck(int n)
        {
            if (n == 1)
                return "1";
            StringBuilder sb = new StringBuilder();
            string s = Fuck(n - 1);
            var tem_c = s[0];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == tem_c)
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(tem_c);
                    tem_c = s[i];
                    count = 1;
                }
            }
            sb.Append(count);
            sb.Append(tem_c);
            return sb.ToString();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 22. 括号生成
    /// </summary>
    public class Solution_22
    {
        public static List<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            GenerateParenthesisHelper(ref result, "", 0, 0, n);
            return result;
        }

        static void GenerateParenthesisHelper(ref List<string> result, string ans, int left, int right, int max)
        {
            if(ans.Length>=max*2)
            {
                result.Add(ans);
                return;
            }

            if (left < max)
                GenerateParenthesisHelper(ref result, ans + '(', left + 1, right, max);
            if (right < left)
                GenerateParenthesisHelper(ref result, ans + ')', left, right + 1, max);
        }
    }
}

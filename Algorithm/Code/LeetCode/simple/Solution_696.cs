using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_696
    {
        public int CountBinarySubstrings(string s)
        {
            int result = 0;
            int count = 0;
            int tem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && s[i] != s[i - 1])
                {
                    result += Math.Min(count, tem);
                    count = tem;
                    tem = 0;
                }
                tem++;
            }
            result += Math.Min(count, tem);
            return result;

        }
        /*
         * 超时
         */
        //public int CountBinarySubstrings(string s)
        //{
        //    int result = 0;
        //    for(int i=0;i<s.Length;i++)
        //    {
        //        int count0 = 0, count1 = 0;
        //        char beginNum = s[i];
        //        bool flag = false;
        //        for (int j=i;j<s.Length;j++)
        //        {
        //            if (s[j] == beginNum && flag) break;
        //            if (s[j] != beginNum) flag = true;
        //            if (s[j] == '0') count0++;
        //            else count1++;
        //            if (count0 == count1) break;
        //        }
        //        if (count0 == count1) result++;

        //    }
        //    return result;


        //}
    }
}

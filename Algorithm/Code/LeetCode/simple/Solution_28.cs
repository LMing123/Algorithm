using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 28. 实现strStr()
    /// </summary>
    public class Solution_28
    {
        public static int StrStr(string haystack, string needle)
        {
            
            if (needle.Length == 0)
                return 0;
            for(int i=0;i<haystack.Length;i++)
            {
                int j = 0;
                int k = i;
                while(k<haystack.Length&&j<needle.Length&&haystack[k]==needle[j])
                {
                    k++;
                    j++;
                }
                if(j==needle.Length)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

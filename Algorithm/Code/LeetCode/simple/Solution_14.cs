using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    /// <summary>
    /// 14. 最长公共前缀
    /// </summary>
    public class Solution_14
    {
        public static string Func(string[] strs)
        {
            int minLength = int.MaxValue;
            if(strs.Length==0)
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<strs.Length;i++)
            {
                if(strs[i].Length<minLength)
                {
                    minLength = strs[i].Length;
                }
            }

            for(int i=0;i<minLength;i++)
            {
                sb.Append(strs[0][i]);
                for (int j=1;j<strs.Length;j++)
                {
                    if(strs[j].Substring(0,i+1)!=sb.ToString())
                    {
                        return sb.Remove(i,1).ToString();
                    }
                }
            }

            return sb.ToString();


        }
    }
}

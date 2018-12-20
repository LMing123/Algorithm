using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 67. 二进制求和
    /// </summary>
    class Solution_67
    {
        public static string Fuck(string  a,string b)
        {
            if (a.Length > b.Length)
            {
                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < a.Length - b.Length; i++)
                    temp.Append("0");
                b=b.Insert(0, temp.ToString());

            }                
            else
            {
                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < b.Length - a.Length; i++)
                    temp.Append("0");
                a = a.Insert(0, temp.ToString());
            }
                
            int length = a.Length;
            StringBuilder sb = new StringBuilder();
            bool isCarry = false;
            for(int i=b.Length-1;i>=0;i--)
            {
                int tep = 0;
                if (isCarry)
                {
                    tep = 1;
                    isCarry = false;
                }
                   
                if ((a[i]-'0')+(b[i]-'0')+tep >1)
                {
                    if((a[i] - '0') + (b[i] - '0')>1)
                    {
                        if (tep == 1)
                        {
                            sb.Insert(0, "1");

                        }
                        else
                        {
                            sb.Insert(0, "0");
                        }
                    }
                    else
                    {
                        sb.Insert(0, "0");
                    }
                    isCarry = true;
                }
                else
                {
                    if((a[i] - '0') + (b[i] - '0') + tep == 1)
                        sb.Insert(0, "1");
                    else
                        sb.Insert(0, "0");
                    isCarry = false;
                }
            }
            if(isCarry)
                sb.Insert(0, "1");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 70. 爬楼梯
    /// 输入： 2
    /// 输出： 2
    /// 解释： 有两种方法可以爬到楼顶。
    /// 1.  1 阶 + 1 阶
    /// 2.  2 阶
    /// </summary>
    class Solution_70
    {
        static Dictionary<int, int> result = new Dictionary<int, int>()
        {
            { 0,1},
            {1,1 }
        };
        public static int Func(int n)
        {
            if (n==0||n==1)
                return result[n];
            else
            {
                int value = 0;
                for(int i=0;i<=n;i++)
                {
                    if(result.ContainsKey(i))
                        value = value+ result[i];
                    else
                    {
                        result.Add(i, result[i-1]+result[i-2]);
                    }
                }
            }
            return result[n];
            
        }
    }
}

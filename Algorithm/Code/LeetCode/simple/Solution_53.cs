using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 53. 最大子序和
    /// </summary>
    class Solution_53
    {
        public static int Fuck(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int max = int.MinValue;
            int tem = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(tem>=0)
                {
                    tem += nums[i];
                }
                else
                {
                    tem = nums[i];
                }
                if (tem > max)
                    max = tem;
            }
            return max;
        }
    }
}

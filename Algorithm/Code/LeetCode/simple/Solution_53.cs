using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 53. 最大子序和
    ///  给定一个整数数组 nums ，找到一个具有最大和的连续子数组
    ///  （子数组最少包含一个元素），返回其最大和.
    ///  输入: [-2,1,-3,4,-1,2,1,-5,4]
    ///  输出: 6
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

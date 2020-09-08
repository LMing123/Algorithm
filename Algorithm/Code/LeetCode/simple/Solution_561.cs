using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_561
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;
            for(int i=0;i<nums.Length;i+=2)
            {
                result += nums[i];
            }
            return result;
        }

        public int ArrayPairSum1(int[] nums)
        {
            int[] list = new int[20001];
            int index = 10000;
            for(int i=0;i<nums.Length;i++)
            {
                list[nums[i] - index]++;
            }

            int result = 0, flag = 0; //flag 记录这个数字被上一次计算用掉了几个
            for(int i=-10000;i<=10000;i++)
            {
                result += (list[i - index] - flag + 1) / 2 * i; //+1取整继续为0
                flag = (list[i - index] - flag+2) % 2;  //+2为了防止出现负数
            }
            return result;
        }
    }
}

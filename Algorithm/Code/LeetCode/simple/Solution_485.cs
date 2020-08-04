using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int tem = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] == 1)
                {
                    tem++;
                    result = tem > result ? tem : result;
                }
                else
                {
                    result = tem > result ? tem : result;
                    tem = 0;
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_674
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int length = 0;

            int tem = 1;
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i] - nums[i - 1] > 0) tem++;
                else tem = 1;
                if (tem > length) length = tem;
            }
            return length;
        }
    }
}

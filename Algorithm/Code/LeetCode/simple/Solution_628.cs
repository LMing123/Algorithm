using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_628
    {

        public int MaximumProduct(int[] nums)
        {
            int min1 = 1001, min2 = 1001;
            int max1 = -1001, max2 = -1001, max3 = -1001;

            for (int i = 0; i < nums.Length; i++)
            {
                int tem = nums[i];
                if (tem < min1)
                {
                    min2 = min1;
                    min1 = tem;
                }
                else if (tem < min2)
                {
                    min2 = tem;
                }
                if (tem > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = tem;
                }
                else if (tem > max2)
                {
                    max3 = max2;
                    max2 = tem;
                }
                else if (tem > max3)
                {
                    max3 = tem;
                }
            }

            return Math.Max(min1 * min2 * max1, max1 * max2 * max3);

        }
        public int MaximumProduct1(int[] nums)
        {
            Array.Sort(nums);
            int tem = nums[0] * nums[1] * nums[nums.Length-1];
            int tem2 = nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1];

            return Math.Max(tem, tem2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.FUCK
{
    class Solution_453
    {
        public static int MinMoves(int[] nums)
        {
            Array.Sort(nums);
            var result = 0;
            for(int i=1;i<nums.Length;i++)
            {
                int diff = result+nums[i] - nums[i - 1];
                nums[i] += result;
                result += diff;
            }
            return result;  
        }
    }
}

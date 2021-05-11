using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_724
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 0) return -1;
            var sum = nums.Sum();
            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum - nums[i] == leftSum) return i;
                leftSum += nums[i];
                sum -= nums[i];
            }
            return -1;

        }
    }
}

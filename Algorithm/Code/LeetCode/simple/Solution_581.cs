using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_581
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            if (nums.Length == 1) return 1;
            if (nums.Length == 0) return 0;

            var list = new List<int>(nums);
            list.Sort();

            int i = 0, j = nums.Length - 1;
            while(i<j)
            {
                if (nums[i] == list[i]) i++;
                if (nums[j] == list[j]) j--;
                if (nums[i] != list[i] && nums[j] != list[j]) break;
            }
            return i == j ? 0: j - i + 1;
        }
    }
}

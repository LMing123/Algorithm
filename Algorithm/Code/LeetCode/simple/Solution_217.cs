using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> shit = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(shit.Contains(nums[i]))
                {
                    return true;
                }
                shit.Add(nums[i]);
            }
            return false;
        }
    }
}

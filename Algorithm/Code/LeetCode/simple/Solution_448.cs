using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> list = new List<int>(nums.Length);
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[Math.Abs(nums[i])-1] < 0) continue;
                nums[Math.Abs(nums[i]) - 1] = nums[Math.Abs(nums[i]) - 1] * -1;
            }

            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] >= 0) list.Add(i + 1);
            }

            return list;
        }
    }
}

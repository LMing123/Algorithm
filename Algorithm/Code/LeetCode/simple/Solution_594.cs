using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_594
    {
        public int FindLHS(int[] nums)
        {
            var list = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (list.ContainsKey(nums[i])) list[nums[i]]++;
                else list.Add(nums[i], 1);
            }

            int max = 0;
            foreach (var item in list)
            {
                if (list.ContainsKey(item.Key + 1)) max = Math.Max(max, list[item.Key + 1] + item.Value);
                else if(list.ContainsKey(item.Key - 1)) max = Math.Max(max, list[item.Key - 1] + item.Value);
            }
            return max;
        }
    }
}

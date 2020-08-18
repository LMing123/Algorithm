using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_506
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            Dictionary<int, int> lists = new Dictionary<int, int>(nums.Length);
            string[] result = new string[nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                lists.Add(nums[i], i);
            }

            Array.Sort<int>(nums);
            int j = 1;
            for(int i=nums.Length-1;i>=0;i--,j++)
            {
                if (j == 1)
                    result[lists[nums[i]]] = "Gold Medal";
                else if (j == 2)
                    result[lists[nums[i]]] = "Silver Medal";
                else if(j==3)
                    result[lists[nums[i]]] = "Bronze Medal";
                else
                    result[lists[nums[i]]] = j.ToString();

            }
            return result;
        }
    }
}

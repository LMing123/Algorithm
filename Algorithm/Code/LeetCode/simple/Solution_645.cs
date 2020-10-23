using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_645
    {
        public int[] FindErrorNums(int[] nums)
        {
          //  HashSet<int> vs = new HashSet<int>();
            int[] tem = new int[nums.Length + 1];
            int tag = 0;
            int miss = 0;
            for(int i=0;i<nums.Length;i++)
            {
               if(tem[nums[i]] == nums[i])
                {
                    tag = nums[i];
                }
                tem[nums[i]] = nums[i];
            }

            for(int i=0;i<tem.Length;i++)
            {
                if (tem[i] == 0) miss = i;
            }
            return new int[] { tag, miss };
        }
    }
}

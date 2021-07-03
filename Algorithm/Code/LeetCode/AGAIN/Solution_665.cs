using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.Func
{
    public class Solution_665
    {
        public bool CheckPossibility(int[] nums)
        {
            int total = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] <= nums[i + 1]) continue;

                total++;
                if (total > 1) return false;
                if (i - 1 < 0) nums[i] = nums[i + 1];
                else
                {
                    if (i + 2 < nums.Length && nums[i] > nums[i + 2])
                    {
                        nums[i] = nums[i - 1];
                        i = i - 1;
                    }
                    else nums[i + 1] = nums[i];
                }
            }
            return true;
        }
    }
}

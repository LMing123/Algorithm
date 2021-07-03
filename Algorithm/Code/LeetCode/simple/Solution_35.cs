using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 35. 搜索插入位置
    /// </summary>
    class Solution_35
    {
        public static int SearchInsert(int[] nums, int target)
        {
            return On(nums, target);
        }
        private static int On(int[] nums, int target)
        {            
            if (nums.Length == 0)
                return 0;
            int position = 0; ;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] == target)
                {
                    position = i;
                    break;
                }
                else if (nums[i] > target&&i==0)
                {
                    position = i;
                    break;
                }else if (nums[i] < target && i == nums.Length - 1)
                {
                    position = i + 1;
                    break;
                }else if (nums[i] < target && nums[i+1] > target)
                {
                    position = i + 1;
                    break;
                }
            }
            return position;
        }
    }
}

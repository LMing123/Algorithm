using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.hard
{
    class Solution_41
    {
        public int FirstMissingPositive(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                int index = nums[i];
                while(index <= nums.Length&& index > 0&& nums[index-1] != index)
                {
                    int tem = nums[index - 1];
                    nums[index - 1] = index;
                    index = tem;                    
                }
            }

            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] - 1 != i) return i +1;
            }
            return nums.Length+1;
        }
    }
}

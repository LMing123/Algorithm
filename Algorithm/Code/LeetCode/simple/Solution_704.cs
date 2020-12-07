using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_704
    {
        public int Search(int[] nums, int target)
        {
            int begin = 0;
            int end = nums.Length - 1;
            int mid =begin+ (end - begin + 1) / 2;

            while(begin<=end)
            {
                if(target==nums[mid])
                {
                    return mid;
                }else if(target>nums[mid])
                {
                    begin = mid+1 ;                   
                }
                else
                {
                    end = mid-1 ;                   
                }
                mid = begin + (end - begin + 1) / 2;
            }
            return  -1;
        }
    }
}

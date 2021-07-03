using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 33. 搜索旋转排序数组
    /// 假设按照升序排序的数组在预先未知的某个点上进行了旋转。
    /// ( 例如，数组 [0,1,2,4,5,6,7] 可能变为 [4,5,6,7,0,1,2] )。
    /// 搜索一个给定的目标值，如果数组中存在这个目标值，则返回它的索引，否则返回 -1 。
    /// 你可以假设数组中不存在重复的元素。
    /// 你的算法时间复杂度必须是 O(log n) 级别。
    /// </summary>
    public class Solution_33
    {
        public static int Func(int[] nums, int target)
        {
            int position =( nums.Length - 1 )/ 2;
            int end = nums.Length - 1;
            while(position<nums.Length&&nums[end]<nums[position])
            {
                position++;
            }
            if(target<nums[end])
            {
              return  Find(nums, position, end+1,target);
            }
            else
            {
                return Find(nums, 0, position+1, target);
            }
        }

        public static int Find(int[] nums,int start,int end,int target)
        {
            int low = start;
            int high = end - 1;
            while ((low <= high) && (low <= end-1)
        && (high <= end  - 1))
            {
                int middle = (high + low) >> 1;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (target < nums[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return -1;
        }
    }
}

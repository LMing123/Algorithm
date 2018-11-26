using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 34. 在排序数组中查找元素的第一个和最后一个位置
    /// </summary>
    public class Solution_34
    {
        public static int[] Fuck(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = (end + start) / 2;
            int[] result = { -1, -1 };
            for (int i = (end + start) / 2; start<=end; i = (end + start) / 2)
            {
                if (nums[i] > target)
                {
                    end = i-1;
                }                    
                else if(nums[i]<target)
                {
                    start = i+1;
                }
                else
                {
                    int fuck1 = i;
                    int fuck2 = i;
                    while (fuck1-1 >= 0 && nums[fuck1-1] == target)
                        fuck1--;
                    while (fuck2+1 < nums.Length && nums[fuck2+1] == target)
                        fuck2++;
                    result[0] = fuck1;
                    result[1] = fuck2;
                    break;
                }
            }
            return result;
        }
    }
}

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
        public static int[] Func(int[] nums, int target)
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
                    int Func1 = i;
                    int Func2 = i;
                    while (Func1-1 >= 0 && nums[Func1-1] == target)
                        Func1--;
                    while (Func2+1 < nums.Length && nums[Func2+1] == target)
                        Func2++;
                    result[0] = Func1;
                    result[1] = Func2;
                    break;
                }
            }
            return result;
        }
    }
}

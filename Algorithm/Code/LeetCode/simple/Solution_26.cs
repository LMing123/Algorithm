using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 26. 删除排序数组中的重复项
    /// </summary>
    public class Solution_26
    {
        public static int Fuck(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int length = 1;
            int shit = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != shit)
                {
                    nums[length] = nums[i];
                    shit = nums[i];
                    length++;
                }
            }
            return length;
        }
    }
}

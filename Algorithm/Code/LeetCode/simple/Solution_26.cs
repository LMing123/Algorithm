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
        public static int Func(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int length = 1;
            int SpecialS = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != SpecialS)
                {
                    nums[length] = nums[i];
                    SpecialS = nums[i];
                    length++;
                }
            }
            return length;
        }
    }
}

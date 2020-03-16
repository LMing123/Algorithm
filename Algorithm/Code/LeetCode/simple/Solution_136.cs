using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    
   /// <summary>
   /// /// 136. 只出现一次的数字
   /// 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
   /// 
   /// 说明：
    
    /// 你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？
    /// 示例 1:
    /// 输入: [2,2,1]  输出: 1
   /// </summary>
    public class Solution_136
    {
        public static int SingleNumber(int[] nums)
        {
            int result = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
            /// <summary>
            /// ....
            /// </summary>
            /// <param name="nums"></param>
            /// <returns></returns>
            public static int SingleNumber1(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            Dictionary<int, int> table = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
               if(table.ContainsKey(nums[i]))
                {
                    table[nums[i]] += 1;
                }
                else
                {
                    table.Add(nums[i], 1);
                }
            }
            return table.Where(x => x.Value == 1).FirstOrDefault().Key;

           

        }
    }
}

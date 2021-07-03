using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 27. 移除元素
    /// </summary>
    public class Solution_27
    {
        public static int RemoveElement(ref int[] nums,int val)
        {
            int length = nums.Length;
            if (length == 0)
                return 0;
            length = 0;
            int s = nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]!=val)
                {
                    nums[length] = nums[i];
                    length++;
                }
            }
            return length;
        }
    }
}

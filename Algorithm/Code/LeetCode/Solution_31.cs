using System;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 31. 下一个排列
    /// 
    /// 实现获取下一个排列的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列。
    ///如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。
    ///必须原地修改，只允许使用额外常数空间。
    ///以下是一些例子，输入位于左侧列，其相应输出位于右侧列。
    ///1,2,3 → 1,3,2
    ///3,2,1 → 1,2,3
    ///1,1,5 → 1,5,1
    /// </summary>
    public class Solution_31
    {
        public static void Func(ref int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0)
            {
                if (nums[i] < nums[i+1])
                    break;
                i--;
            }
            if(i>=0)
            {
                int position = i + 1;
                while (position < nums.Length)
                {
                    if (nums[position] <= nums[i])
                        break;
                    position++;

                }
                int site = position - 1;

                int tem = nums[i];
                nums[i] = nums[site];
                nums[site] = tem;
                Reverse(ref nums, i + 1);
                return;
            }


            Reverse(ref nums, 0);
        }

        public static void Reverse(ref int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
            while (i < j)
            {
                int tem = nums[i];
                nums[i] = nums[j];
                nums[j] = tem;
                i++; j--;
            }
        }
    }
}

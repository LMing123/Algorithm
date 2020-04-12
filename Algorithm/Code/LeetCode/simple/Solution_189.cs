using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_189
    {


        public static void Rotate(ref int[] nums, int k)
        {
            k = k % nums.Length;
            Reverse(ref nums, 0, nums.Length - 1);
            Reverse(ref nums, 0, k - 1);
            Reverse(ref nums, k, nums.Length - 1);
        }
        private static void Reverse(ref int[] nums, int start, int end)
        {
            while (start < end)
            {
                int tem = nums[start];
                nums[start] = nums[end];
                nums[end] = tem;
                start++; end--;
            }
        }
        ///超时
        //public static void Rotate(ref int[] nums, int k)
        //{
        //    int times = k % nums.Length;
        //    for (int i = 0; i < times; i++)
        //    {
        //        int tem = nums[nums.Length - 1];
        //        for (int j = nums.Length - 1; j > 0; j--)
        //        {
        //            nums[j] = nums[j - 1];
        //        }
        //        nums[0] = tem;
        //    }
        //}
    }
}

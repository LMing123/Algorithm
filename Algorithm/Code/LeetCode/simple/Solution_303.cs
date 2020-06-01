using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_303
    {
      
        int[] vs = null;
        public Solution_303(int[] nums)
        {
            if (nums.Length == 0) return;
            vs = new int[nums.Length];
            vs[0] = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                vs[i] = vs[i-1] + nums[i];
            }
        }
        public int SumRange(int i, int j)
        {
            if (i == 0)
                return vs[j];
            else
            {
                return vs[j] - vs[i - 1];
            }
        }
        //int[,] list = null;
        //public Solution_303(int[] nums)
        //{
        //    list = new int[nums.Length, nums.Length];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i; j < nums.Length; j++)
        //        {
        //            if (i == j)
        //            {
        //                list[i, j] = nums[i];
        //            }
        //            else
        //            {
        //                list[i, j] = list[i, j - 1] + nums[j];
        //            }
        //        }

        //    }
        //}

        //public int SumRange(int i, int j)
        //{
        //    return list[i, j];
        //}
    }
}

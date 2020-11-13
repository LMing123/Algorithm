using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_268
    {
        public static int MissingNumber3(int[] nums)
        {
            int sum = ((nums.Length + 1) * nums.Length) / 2;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return sum - result;

            /***
             * 下面的比直接for循环慢
             ***/
            //int sum = ((nums.Length + 1) * nums.Length) / 2;
            //int result=sum-nums.Sum();
            //return result;
        }
        public static int MissingNumber2(int[] nums)
        {
            int result = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i ^ nums[i];
            }
            return result;

        }
        public static int MissingNumber1(int[] nums)
        {
            HashSet<int> vs = new HashSet<int>(nums);
            int result = 0;
            for(int i=0;i<=nums.Length;i++)
            {
                if (!vs.Contains(i))
                {
                    result = i;
                    break;
                }
            }
            return result;

        }
    }
}

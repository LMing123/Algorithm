using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int max = int.MinValue;
            int[] result = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i - k < 0)
                {
                    if (i == 0)
                        result[i] = nums[i];
                    else 
                        result[i] = nums[i]+ result[i - 1];
                }
                else
                {
                    result[i] = nums[i] + result[i - 1] - nums[i - k];
                  
                }
                if (i + 1 >= k && max < result[i]) max = result[i];
            }
            return ((double)max/(double)k);
           
        }
    }
}

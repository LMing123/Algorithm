using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_198
    {
        public static int Rob(int[] nums)
        {
            int max = -1;
            int length = nums.Length;
            if (length == 0) return 0;
            if (length == 1) return nums[0];
            if (length == 2) return nums[0] > nums[1] ? nums[0] : nums[1];
            int[] result = new int[length];
            max = result[0] = nums[0];
            result[1] = nums[1];
            max = result[1] > max ? result[1] : max;
            for (int i=2;i<length;i++)
            {
                bool first = true;
                for(int j=i;j>=0;)
                {
                    if(first)
                    {
                        if (j - 2 >= 0) result[i] = result[i] > result[j - 2] + nums[i] ? result[i] : result[j - 2] + nums[i];
                        first = false;
                        j = j - 2;
                    }
                    else
                    {
                        if(j-1>=0) result[i] = result[i] > result[j - 1] + nums[i] ? result[i] : result[j - 1] + nums[i];
                        j--;
                    }

                }
                max = result[i] > max ? result[i] : max;
            }
            return max;
        }
    }
}

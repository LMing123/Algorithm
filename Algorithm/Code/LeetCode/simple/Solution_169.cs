using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_169
    {
        public static int Fuck(int[] nums)
        {
            int length = nums.Length;
            int value = 0;
            int max = 0;
            Dictionary<int, int> list = new Dictionary<int, int>();
            for(int i=0;i <  length; i++)
            {
                if (list.ContainsKey(nums[i]))
                {
                    list[nums[i]]++;
                    if(list[nums[i]] > length / 2)
                    {
                       value= nums[i];
                        max = list[nums[i]];
                    }
                }
                else
                {
                    list.Add(nums[i], 1);
                    if (max < 1)
                        value = nums[i];
                }
            }
            return value;

        }
    }
}

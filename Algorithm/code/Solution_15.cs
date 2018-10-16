using System;
using System.Collections.Generic;

namespace ConsoleApp1.code
{
    /// <summary>
    /// 15. 三数之和
    /// </summary>
    public class Solution_15
    {
        public static IList<IList<int>> fuck(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }
            Array.Sort(nums);
            int holy_i = 0;
            int holy_z = nums.Length - 2;
            while(holy_i<holy_z)
            {
                int fuck_i = holy_i + 1;
                int fuck_z = holy_z + 1;
                while(fuck_i<fuck_z&&fuck_i<nums.Length-1&&fuck_z>0)
                {
                    int value = nums[holy_i] + nums[fuck_i] + nums[fuck_z];
                    if(value==0)
                    {
                        result.Add(new List<int> { nums[holy_i] , nums[fuck_i] , nums[fuck_z] });
                        int fff = nums[fuck_i];
                        fuck_i++;
                        while(fff == nums[fuck_i]&& fuck_i < nums.Length - 1)
                        {
                            fuck_i++;
                        }
                        fff = nums[fuck_z];
                        fuck_z--;
                        while (fff == nums[fuck_i] && fuck_z > 0)
                        {
                            fuck_z--;
                        }

                    }
                    else if(value<0)
                    {
                        int fff = nums[fuck_i];
                        fuck_i++;
                        while (fff == nums[fuck_i] && fuck_i < nums.Length - 1)
                        {
                            fuck_i++;
                        }
                    }
                    else
                    {
                       int fff = nums[fuck_z];
                        fuck_z--;
                        while (fff == nums[fuck_i] && fuck_z > 0)
                        {
                            fuck_z--;
                        }
                    }
                }
                int sss = nums[holy_i];
                holy_i++;
                while (sss == nums[holy_i] && holy_i < nums.Length - 1)
                {
                    holy_i++;
                }
            }

            return (IList<IList<int>>)result;
        }
    }
}

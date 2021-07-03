using System;
using System.Collections.Generic;

namespace Algorithm.Code
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
                int f_i = holy_i + 1;
                int f_z = holy_z + 1;
                while(f_i<f_z&&f_i<nums.Length-1&&f_z>0)
                {
                    int value = nums[holy_i] + nums[f_i] + nums[f_z];
                    if(value==0)
                    {
                        result.Add(new List<int> { nums[holy_i] , nums[f_i] , nums[f_z] });
                        int fff = nums[f_i];
                        f_i++;
                        while(fff == nums[f_i]&& f_i < nums.Length - 1)
                        {
                            f_i++;
                        }
                        fff = nums[f_z];
                        f_z--;
                        while (fff == nums[f_i] && f_z > 0)
                        {
                            f_z--;
                        }

                    }
                    else if(value<0)
                    {
                        int fff = nums[f_i];
                        f_i++;
                        while (fff == nums[f_i] && f_i < nums.Length - 1)
                        {
                            f_i++;
                        }
                    }
                    else
                    {
                       int fff = nums[f_z];
                        f_z--;
                        while (fff == nums[f_i] && f_z > 0)
                        {
                            f_z--;
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

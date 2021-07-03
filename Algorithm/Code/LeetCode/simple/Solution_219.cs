using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_219
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> SpecialS = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(SpecialS.ContainsKey(nums[i]))
                {
                    if (Math.Abs(SpecialS[nums[i]] - i) <= k) return true;
                    else  SpecialS[nums[i]] = i;
                }
                else
                {
                    SpecialS.Add(nums[i], i);
                }                
            }
            return false;
        }
        ///TOO SLOW
        public static bool ContainsNearbyDuplicate1(int[] nums, int k)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j=i+1;j<=i+k&&j<nums.Length;j++)
                {
                    if (nums[i] == nums[j]) return true;
                }

            }
            return false;
        }
    }
}

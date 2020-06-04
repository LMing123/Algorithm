using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var list =new  Dictionary<int, int>();
            var result = new List<int>();
            for(int i=0;i<nums1.Length;i++)
            {
                if (list.ContainsKey(nums1[i])) 
                    list[nums1[i]]++;
                else 
                    list[nums1[i]] = 1;
            }
            for(int j=0;j<nums2.Length;j++)
            {
                if (list.ContainsKey(nums2[j]) && list[nums2[j]] != 0)
                {
                    result.Add(nums2[j]);
                    list[nums2[j]]--;
                }
                    
            }
            return result.ToArray();
        }
        public int[] Intersect1(int[] nums1,int[] nums2)
        {
            var result1 = nums1.Where(x => nums1.Intersect(nums2).Contains(x));
            var result2 = nums2.Where(x => nums1.Intersect(nums2).Contains(x));
            return result1.Count() >= result2.Count() ? result2.ToArray() : result1.ToArray();
        }
    }
}

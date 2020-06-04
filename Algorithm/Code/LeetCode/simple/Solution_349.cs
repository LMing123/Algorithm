using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length==0 || nums2.Length == 0) return new int[0];
            var list = new HashSet<int>(nums1);
            HashSet<int> result = new HashSet<int>();
            for(int i=0;i<nums2.Length;i++)
            {
                if (list.Contains(nums2[i])&&!result.Contains(nums2[i])) result.Add(nums2[i]);
            }
            return result.ToArray();

        }
        public int[] Intersection1(int[] nums1, int[] nums2)
        {
            return nums1.Where(x => nums2.Contains(x)).Distinct().ToArray();
        }
    }
}

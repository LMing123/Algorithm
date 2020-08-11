using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
   public class Solution_496
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> list = new Dictionary<int, int>();
            for(int i=0;i<nums2.Length;i++)
            {
                while (stack.Count != 0 && nums2[i] > stack.Peek())
                    list.Add(stack.Pop(), nums2[i]);
                stack.Push(nums2[i]);                
            }

            while(stack.Count!=0)
            {
                list.Add(stack.Pop(), -1);
            }
            int[] result = new int[nums1.Length];
            for(int i=0;i<nums1.Length;i++)
            {
                result[i] = list[nums1[i]];
            }
            return result;
        }
    }
}

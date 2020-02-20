using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_108
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {

            int length = nums.Length;
            if (length < 1) return null;
            if (length == 1)
            {
                return new TreeNode(nums[0]);
            }

            var position = length / 2;
            TreeNode node = new TreeNode(nums[position]);
            int[] nums1=new int[position];
            Array.Copy(nums, 0, nums1, 0, position);
            node.left = SortedArrayToBST(nums1);
            int[] nums2 = new int[length-position-1];
            Array.Copy(nums,position+1, nums2, 0, length - position - 1);
            node.right = SortedArrayToBST(nums2);
            return node;

        }

        public static TreeNode SortedArrayToBST1(int[] nums,int start,int end)
        {

            
            if (start>end) return null;


            var position = (start+end) / 2;
            TreeNode node = new TreeNode(nums[position]);

            node.left = SortedArrayToBST1(nums,start,position-1);
            node.right = SortedArrayToBST1(nums, position+1, end);
            return node;

        }



    }
}

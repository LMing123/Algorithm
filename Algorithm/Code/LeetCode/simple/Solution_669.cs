using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_669
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return null;
            var left = TrimBST(root.left,low,high);
            var right = TrimBST(root.right, low, high);

            root.left = left;
            root.right = right;


            if (root.val > high) return left;
            else if (root.val < low) return right;
            else return root;

        }
    }
}

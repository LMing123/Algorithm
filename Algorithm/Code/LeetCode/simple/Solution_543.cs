using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_543
    {
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
             Helper(root);
            return max;

        }

        public int Helper(TreeNode root)
        {
            if (root== null) return 0;

            int left = Helper(root.left);
            int right = Helper(root.right);
            max = Math.Max(left + right, max);
            return Math.Max(left, right)+1;
        }
    }
}

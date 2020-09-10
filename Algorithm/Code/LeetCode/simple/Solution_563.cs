using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_563
    {
        int result = 0;
        public int FindTilt(TreeNode root)
        {
            Helper(root);
            return result;
        }

        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            int left = Helper(root.left);
            int right = Helper(root.right);
            result += Math.Abs(left - right);
            return root.val+left+right;
        }
    }
}

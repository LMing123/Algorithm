using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_404
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;
            if (root == null) return 0;
            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                {
                    result += root.left.val;
                }
                else
                {
                    result += SumOfLeftLeaves(root.left);
                }
            }

            result += SumOfLeftLeaves(root.right);
            return result;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_226
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            InvertTree(root.left);
            InvertTree(root.right);
            var tem = root.left;
            root.left = root.right;
            root.right = tem;
            return root;
        }
    }
}

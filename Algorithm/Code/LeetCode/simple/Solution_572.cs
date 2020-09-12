using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_572
    {
        List<TreeNode> list = new List<TreeNode>();
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            FindRoot(s, t);
            bool result = false;
            for (int i = 0; i < list.Count; i++)
            {
                result = result || Helper(list[i], t);
            }
            return result;
        }


        public void FindRoot(TreeNode s, TreeNode t)
        {
            if (s == null) return;
            if (s.val == t.val) list.Add(s);
            FindRoot(s.left, t);
            FindRoot(s.right, t);
        }


        public bool Helper(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null && t != null) return false;
            if (s != null && t == null) return false;
            if (s.val != t.val) return false;

            return Helper(s.left, t.left) && Helper(s.right, t.right);
        }
    }
}

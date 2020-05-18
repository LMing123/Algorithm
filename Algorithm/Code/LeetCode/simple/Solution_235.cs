using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_235
    {

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val > q.val)
            {
                var tem = p;
                p = q;
                q = tem;
            }
            while (root!=null)
            {
                if (p.val < root.val && q.val < root.val)
                {
                    root = root.left;
                }
                else if((p.val > root.val && q.val > root.val))
                {
                    root = root.right;
                }else
                {
                    return root;
                }
            }
            return root;
        }
      
        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (p.val > q.val)
            {
                var tem = p;
                p = q;
                q = tem;
            }
            TreeNode result = root;
            if ((root.val >= p.val && root.val <= q.val)) return result;
            if (p.val < root.val && q.val < root.val)
            {
                result = LowestCommonAncestor(root.left, p, q) ?? result;
            }
            else
            {
                result = LowestCommonAncestor(root.right, p, q) ?? result;
            }

            return result;

        }

    }
}

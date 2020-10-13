using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_617
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return t1;
            if(t1!=null&&t2!=null)
            {
                t1.val += t2.val;
                MergeTrees(t1.left, t2.left);
                MergeTrees(t1.right, t2.right);
                if (t1.left == null && t2.left != null)
                {
                    t1.left = t2.left;

                }
                if (t1.right == null && t2.right != null)
                {
                    t1.right = t2.right;
                }
                return t1;

            }
            return t1==null?t2:t1;

        }
    }
}

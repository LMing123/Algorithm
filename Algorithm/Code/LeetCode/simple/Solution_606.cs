using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_606
    {
        StringBuilder sb1 = new StringBuilder();

        public string Tree2str2(TreeNode t)
        {
            Helper(t);
            return sb1.ToString();           
         
        }
 
        void Helper(TreeNode t)
        {
            if (t == null) return;
            sb1.Append(t.val);
            if (t.left != null || t.right != null)
            {
                sb1.Append("(");
                Helper(t.left);
                sb1.Append(")");
                if (t.right != null)
                {
                    sb1.Append("(");
                    Helper(t.right);
                    sb1.Append(")");
                }
            }
            //return sb1.ToString();
        }
        public string Tree2str(TreeNode t)
        {
            if (t == null) return "";
            StringBuilder sb = new StringBuilder();

            sb.Append(t.val);
            var left = Tree2str(t.left);
            var right = Tree2str(t.right);
            if (string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right)) return sb.ToString();

            else if (string.IsNullOrEmpty(left) && !string.IsNullOrEmpty(right)) return sb.Append($"()({right})").ToString();
            else if (!string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right)) return sb.Append($"({left})").ToString();
            else return sb.Append($"({left})({right})").ToString();
        }

    }
}

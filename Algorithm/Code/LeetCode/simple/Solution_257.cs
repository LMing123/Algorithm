using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_257
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if(root==null) return null;
            IList<string> list = new List<string>();
            string s = root.val.ToString();
            if (root.left == null && root.right == null) list.Add(s);
            if (root.left != null) Func(ref list, s, root.left);
            if (root.right != null) Func(ref list, s, root.right);
            return list;
        }

        void Func(ref IList<string>list,string s,TreeNode node)
        {
            s = s + $"->{node.val}";
            if (node.left == null && node.right == null)
            {
                list.Add(s);
                return;
            }
            if (node.left != null) Func(ref list, s, node.left);
            if(node.right!=null) Func(ref list, s, node.right);


        }
    }
}

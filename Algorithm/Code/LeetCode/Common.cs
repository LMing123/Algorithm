using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    public class Common
    {
        public static TreeNode BulidTree(ref int?[] a)
        {
            int i = 0;
            if (a.Length == 0) return null;
            if (a[0] == null) return null;
            TreeNode root = new TreeNode(a[0].Value);
            i++;
            Tree(ref root.left,ref root.right, ref a, ref i);
            return root;
        }
        static void Tree(ref TreeNode left,ref TreeNode right, ref int?[] a, ref int i)
        {
            if (i >= a.Length) return;
            if (a[i] == null)
            {
                left = null;
            }
            else
            {
                left = new TreeNode(a[i].Value);

            }

            if (i + 1 >= a.Length) return;
            if (a[i + 1] == null)
            {
                right = null;
            }
            else
            {
                right = new TreeNode(a[i + 1].Value);

            }

            i+=2;
            if (left != null)
            {
                Tree(ref left.left, ref left.right, ref a, ref i);

            }
            if (right != null)
            {
                Tree(ref right.left, ref right.right, ref a, ref i);
            }

        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}

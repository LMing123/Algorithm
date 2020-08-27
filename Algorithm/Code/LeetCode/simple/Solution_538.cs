using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_538
    {
        public TreeNode prev;

        public TreeNode ConvertBST(TreeNode root)
        {
            Helper(root);
            return root;
        }

        public TreeNode Helper(TreeNode root)
        {
            if (root == null) return root;
            var right = Helper(root.right);
            if (prev != null)
            {
                root.val +=  prev.val;
            }
            else
            {
                root.val += right == null ? 0 : right.val;
            }

            //  root.val+= prev == null ? 0 : prev.val;
            prev = root;
            var left = Helper(root.left);
            prev = null;
            if (left != null) return left;

            return root;
        }

        //public List<TreeNode> list;
        //public TreeNode ConvertBST(TreeNode root)
        //{
        //    list = new List<TreeNode>();

        //    for (int i = list.Count- 2; i >= 0; i--)
        //    {
        //        list[i].val += list[i - 1].val;
        //    }
        //    return root;
        //}

        //public void Helper(TreeNode node)
        //{
        //    if (node == null) return;
        //    Helper(node.left);
        //    list.Add(node);
        //    Helper(node.right);
        //}


    }
}

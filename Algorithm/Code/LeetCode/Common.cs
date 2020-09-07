using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    public class Common
    {
        public static ListNode BuildList(int[] a)
        {
            if (a.Length==0) return null;
            var head = new ListNode(a[0]);
            var node = head;
            for(int i=1;i<a.Length;i++)
            {
                node.next = new ListNode(a[i]);
                node = node.next;
            }
            return head;

        }
        public static TreeNode BulidTree(ref int?[] a)
        {
            if (a.Length == 0) return null;
            if (a[0] == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(a[0].Value);
            queue.Enqueue(root);
            for (int i=0;i<a.Length;i++)
            {
                if (queue.Count == 0) break;
                var node = queue.Dequeue();
                int left_posi = 2 * i + 1;
                if (left_posi >= a.Length || a[left_posi] == null)
                {
                    node.left = null;
                }
                else
                {
                    node.left = new TreeNode(a[left_posi].Value);
                }
                if (node.left != null) queue.Enqueue(node.left);
                int right_posi = 2 * i + 2;
                if (right_posi >= a.Length || a[right_posi] == null)
                {
                    node.right = null;
                }
                else
                {
                    node.right = new TreeNode(a[right_posi].Value);
                }
                if (node.right != null) queue.Enqueue(node.right);
            }
            return root;
        }
        //public static TreeNode BulidTree(ref int?[] a)
        //{
        //    int i = 0;
        //    if (a.Length == 0) return null;
        //    if (a[0] == null) return null;
        //    TreeNode root = new TreeNode(a[0].Value);
        //    Tree(ref root.left,ref root.right, ref a, ref i);
        //    return root;
        //}

        //static void Tree(ref TreeNode left,ref TreeNode right, ref int?[] a, ref int i)
        //{
        //    if (i >= a.Length) return;
        //    int left_posi = 2 * i + 1;
        //    if (left_posi>=a.Length|| a[left_posi] == null)
        //    {
        //        left = null;
        //    }
        //    else
        //    {
        //        left = new TreeNode(a[left_posi].Value);

        //    }
        //    int right_posi = 2 * i + 2;
        //    //if (i + 1 >= a.Length) return;
        //    if (right_posi>=a.Length||a[right_posi] == null)
        //    {
        //        right = null;
        //    }
        //    else
        //    {
        //        right = new TreeNode(a[right_posi].Value);

        //    }

        //    i+=1;
        //    if (left != null)
        //    {
        //        Tree(ref left.left, ref left.right, ref a, ref i);

        //    }
        //    if (right != null)
        //    {
        //        Tree(ref right.left, ref right.right, ref a, ref i);
        //    }

        //}
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}

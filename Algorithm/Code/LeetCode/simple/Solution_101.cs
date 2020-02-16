using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    // public class TreeNode
    //{
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //    public TreeNode(int x) { val = x; }
    //}
    /// <summary>
    /// 给定一个二叉树，检查它是否是镜像对称的。
    /// 例如，二叉树[1, 2, 2, 3, 4, 4, 3] 是对称的。
    /// </summary>
    class Solution_101
    {
        public bool Fuck(TreeNode root)
        {
            return Tree(root, root);
        }
        public bool Fuck2(TreeNode root)
        {
            return Tree2(root);
            
        }
        public bool Tree(TreeNode node1,TreeNode node2)
        {

            if (node1 == null && node2 == null)
                return true;
            if (node1 == null || node2 == null)
                return false;

            return (node1.val == node2.val) &&
              Tree(node1.left, node2.right) &&
              Tree(node1.right,node2.left);

        }
        //[1,2,3,3,null,2,null]
        //[5,4,1,null,1,null,4,2,null,2,null]
        public bool Tree2(TreeNode node)
        {
            Queue<TreeNode> list = new Queue<TreeNode>();

            if (node == null)
                return true;
            list.Enqueue(node.left);
            list.Enqueue(node.right);

            while(list.Count!=0)
            {
                var q = list.Dequeue();
                var p = list.Dequeue();
                if (node.left == null && node.right == null)
                    continue;
                if (q == null || p == null)
                    return false;
                if (q.val != p.val)
                    return false;
                list.Enqueue(q.left);
                list.Enqueue(p.right);

                list.Enqueue(q.right);
                list.Enqueue(p.left);

            }
            return true;
            

        }
    }
}

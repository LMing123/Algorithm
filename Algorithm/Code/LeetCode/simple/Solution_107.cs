using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）
    /// 例如：
    /// 给定二叉树 [3,9,20,null,null,15,7],
    /// </summary>
    public class Solution_107
    {
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<IList<int>> lists = new List<IList<int>>();
            SpecialS(queue, lists);
            lists.Reverse();
            return (IList<IList<int>>)lists;
        }

        public static void SpecialS(Queue<TreeNode> queue, List<IList<int>> lists)
        {
            if (queue.Count == 0) return;
            var list = new List<int>();
            var queue2 = new Queue<TreeNode>();
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    queue2.Enqueue(node.left);
                    queue2.Enqueue(node.right);
                    list.Add(node.val);
                }
            }
            if (list.Count != 0)
                lists.Add(list);
            SpecialS(queue2, lists);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个二叉树，找出其最大深度。

    /// 二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。
    /// 说明: 叶子节点是指没有子节点的节点。
    /// 示例：
    /// 给定二叉树[3, 9, 20, null, null, 15, 7]，
    /// 
    /// </summary>
    public class Solution_104
    {


        public static int MaxDepth(TreeNode node)
        {
            int i = 0;
            if (node == null)
                return 0;
            i++;
            int j = MaxDepth(node.left);
            int k = MaxDepth(node.right);
            return j > k ? i + j : i + k;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_437
    {
        public static int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int result = 0;
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            while (treeNodes.Count != 0)
            {
                var node = treeNodes.Dequeue();
                result += HasResult(node, sum);
                if (node.left != null) treeNodes.Enqueue(node.left);
                if (node.right != null) treeNodes.Enqueue(node.right);
            }
            return result;
        }
        private static int HasResult(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int result = 0;
            result+= HasResult(root.left, sum - root.val) + HasResult(root.right, sum - root.val);
            if (root.val == sum) result+=1;
            return result;
        }
    }
}


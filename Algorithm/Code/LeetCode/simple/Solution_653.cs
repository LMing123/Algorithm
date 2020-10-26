using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_653
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null) return false;
            return Helper(root, k);

        }
        public bool Helper(TreeNode node, int k)
        {
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            HashSet<int> values = new HashSet<int>();
            nodes.Enqueue(node);
            while (nodes.Count > 0)
            {
                var tem = nodes.Dequeue();
                var expect = k - tem.val;
                if (values.Contains(expect))
                {
                    return true;
                }

                values.Add(tem.val);

                if (tem.left != null) nodes.Enqueue(tem.left);
                if (tem.right != null) nodes.Enqueue(tem.right);

            }
            return false;
        }
    }
}

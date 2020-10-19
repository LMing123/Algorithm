using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null) return new List<double>() { 0 };
            List<double> result = new List<double>();
            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();

            stack1.Push(root);

            while(stack1.Count>0||stack2.Count>0)
            {
                double count = 0;
                int i=0;
                while(stack1.Count>0)
                {
                   var node= stack1.Pop();
                    if (node.left != null) stack2.Push(node.left);
                    if (node.right != null) stack2.Push(node.right);
                    count += node.val;
                    i++;
                }
                if(i!=0)
                {
                    result.Add((double)count / (double)i);
                }
                i = 0;
                count = 0;
                while (stack2.Count > 0)
                {
                    var node = stack2.Pop();
                    if (node.left != null) stack1.Push(node.left);
                    if (node.right != null) stack1.Push(node.right);
                    count += node.val;
                    i++;
                }
                if (i != 0)
                {
                    result.Add((double)count / (double)i);
                }

            }
            return result;

        }
    }
}

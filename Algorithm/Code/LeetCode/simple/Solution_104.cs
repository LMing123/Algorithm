using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    //class TreeNode
    public class Solution_104
    {

        public static int MaxDepth(TreeNode node)
        {
            int max = 0;
            int i = 0;
            if (node == null)
                return 0;
            i++;
            int j = 0;
            j += MaxDepth(node.left);
            int k = 0;
            k += MaxDepth(node.right);
            return j > k ? i + j : i + k;

        }

    }
}

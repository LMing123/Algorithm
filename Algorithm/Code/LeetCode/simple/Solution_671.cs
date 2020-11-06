using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_671
    {
        int first = -1;
        int second = -1;
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root.left == null) return -1;
            first = root.val;
            return second;
        }

        void Helper(TreeNode root)
        {
            if (root== null) return ;
            if(root.val>first)
            {
                if (second == -1) second = root.val;
                else if (root.val < second) second = root.val;
            }

            Helper(root.left);
            Helper(root.right);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_530
    {
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> list = new List<int>();
            TravelTree(root, ref list);
            int result = int.MaxValue;
            for(int i=1;i<list.Count; i++)
            {
                if ((list[i] - list[i - 1]) < result) 
                    result = list[i] - list[i - 1];
            }
            return result;
        }

       void TravelTree(TreeNode root,ref List<int> lists)
        {
            if (root == null) return;
            TravelTree(root.left,ref lists);
            lists.Add(root.val);
            TravelTree(root.right, ref lists);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_501
    {
        Dictionary<int, int> lists = new Dictionary<int, int>();
        public int[] FindMode(TreeNode root)
        {
            if (root == null) return new int[] { };
            SearchTree(root);
            var result = lists.GroupBy(x => x.Value).OrderByDescending(y => y.Key).FirstOrDefault().ToList().Select(x => x.Key);
            return result.ToArray();

        }
        public void SearchTree(TreeNode root)
        {
            if (root == null) return;
            if(lists.ContainsKey(root.val))
            {
                lists[root.val] += 1;
            }
            else
            {
                lists.Add(root.val, 1);
            }
            SearchTree(root.left);
            SearchTree(root.right);
        }
    }
}

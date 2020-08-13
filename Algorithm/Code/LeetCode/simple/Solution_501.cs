using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_501
    {
        int maxCount = 0;
        int currCount = 0;
        int allCount = 0;
        int[] list = null;
        TreeNode prev = null;

        public int[] FindMode(TreeNode root)
        {
            HelpMethod(root);
            list = new int[allCount];
            currCount = 0;
            allCount = 0;
            HelpMethod(root);
            return list;
        }

        void HelpMethod(TreeNode root)
        {
            if (root == null) return;
            HelpMethod(root.left);
            if (prev!= null && prev.val == root.val)
            {
                currCount++;
            }
            else
            {
                currCount = 1;
            }
            
            if (currCount > maxCount)
            {
                maxCount = currCount;
                allCount = 1;
            }else if(currCount==maxCount)
            {
                if (list != null)
                    list[allCount] = root.val;
                allCount++;
            }
            
            HelpMethod(root.right);
            prev = root;
        }

        #region first method
        //Dictionary<int, int> lists = new Dictionary<int, int>();
        //public int[] FindMode(TreeNode root)
        //{
        //    if (root == null) return new int[] { };
        //    SearchTree(root);
        //    var result = lists.GroupBy(x => x.Value).OrderByDescending(y => y.Key).FirstOrDefault().ToList().Select(x => x.Key);
        //    return result.ToArray();

        //}
        //public void SearchTree(TreeNode root)
        //{
        //    if (root == null) return;
        //    if(lists.ContainsKey(root.val))
        //    {
        //        lists[root.val] += 1;
        //    }
        //    else
        //    {
        //        lists.Add(root.val, 1);
        //    }
        //    SearchTree(root.left);
        //    SearchTree(root.right);
        //}
        #endregion
    }
}

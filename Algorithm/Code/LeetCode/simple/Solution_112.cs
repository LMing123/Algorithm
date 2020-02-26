using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。
    /// 说明: 叶子节点是指没有子节点的节点。
    /// [5,4,8,11,null,13,4,7,2,null,null,null,1],22  true
    /// </summary>
    public class Solution_112
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null&&root.right==null)
            {
                int tem = sum - root.val;
                if(tem == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                bool result = false;
                if(root.left!=null)
                {
                    result = result || HasPathSum(root.left, sum - root.val);
                }
                if (result) return result;

              if(root.right!=null)
                {
                    result = result || HasPathSum(root.right, sum - root.val);
                }
                
                return result;
            }
           
        }
    }
}

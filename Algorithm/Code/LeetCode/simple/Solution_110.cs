using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个二叉树，判断它是否是高度平衡的二叉树。
    /// 本题中，一棵高度平衡二叉树定义为：
    /// 一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。
    /// 示例 1:
    /// 给定二叉树[3, 9, 20, null, null, 15, 7] , true
    /// [1,2,2,3,3,null,null,4,4], false
    /// 来源：力扣（LeetCode）链接：https://leetcode-cn.com/problems/balanced-binary-tree
    /// </summary>
    public class Solution_110
    {
        
        
        public static bool IsBalanced(TreeNode root)
        {

            if (root == null) return true;
            bool result=true;
            result=result&&IsBalanced(root.left);
            if (!result) return result;
            int value = Deep(root.left) - Deep(root.right);
            if ( value>1||value<-1)
            {
                result = result&& false;
                if (!result) return result;
            }
            else
            {
                result = result&&IsBalanced(root.right);
                if (!result) return result;
                value = Deep(root.left) - Deep(root.right);
                if (value > 1 || value < -1)
                {
                    result= result&& false;
                }             
            }
            return result;

        }
         public static int Deep(TreeNode node )
        {
            if (node == null) return 0;

            int left = Deep(node.left);
            int right = Deep(node.right);
            return left > right ? left+1 : right+1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个二叉树，找出其最小深度。
    /// 最小深度是从根节点到最近叶子节点的最短路径上的节点数量。
    /// 说明: 叶子节点是指没有子节点的节点。
    /// 示例:
    /// 给定二叉树 [3,9,20,null,null,15,7],
    /// 来源：力扣（LeetCode）链接：https://leetcode-cn.com/problems/minimum-depth-of-binary-tree
    /// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    /// </summary>
    public class Solution_111
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            
            if(root.right==null)
            {
                int j = MinDepth(root.left);
                return j + 1;
            }else if(root.left==null)
            {
                int k = MinDepth(root.right);
                return k + 1;
            }
            else
            {
                int j = MinDepth(root.left);
                int k = MinDepth(root.right);
                return j < k ? j + 1 : k + 1;
            }  

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
   public class Solution_110
    {
        
        public static bool IsBalanced(TreeNode root)
        {

            if (root == null) return true;
            bool result=true;
            result=result&&IsBalanced(root.left);
            int value = Deep(root.left) - Deep(root.right);
            if ( value>1||value<-1)
            {
                result = result&& false;
            }
            else
            {
                result = result&&IsBalanced(root.right);
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

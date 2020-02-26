using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
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

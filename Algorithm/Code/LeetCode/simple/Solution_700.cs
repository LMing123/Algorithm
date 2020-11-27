using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            var result = SearchBST(root.left, val);
            if (result != null) return result;
            return SearchBST(root.right, val);

        }
    }
}

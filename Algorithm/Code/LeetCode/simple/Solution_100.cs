namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 100. 相同的树
    /// </summary>
    class Solution_100
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static (TreeNode p, TreeNode q) CreateSameTree()
        {
            TreeNode p = new TreeNode(1);
            TreeNode q = new TreeNode(1);
            p.left = new TreeNode(2);
            q.left = new TreeNode(2);
            p.right = new TreeNode(3);
            q.right = new TreeNode(3);
            return (p, q);
        }
        public static (TreeNode p, TreeNode q) CreateDiffTree()
        {
            TreeNode p = new TreeNode(1);
            TreeNode q = new TreeNode(1);
            p.left = null;
            q.left = new TreeNode(2);
            p.right = new TreeNode(3);
            q.right = new TreeNode(3);
            return (p, q);
        }

        public static bool Fuck(TreeNode p, TreeNode q)
        {
            if(p!=null&&q!=null)
            {
                if (p.val == q.val)
                {
                    if (Fuck(p.left, q.left) && Fuck(p.right, q.right))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }else if(p==null&&q==null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}

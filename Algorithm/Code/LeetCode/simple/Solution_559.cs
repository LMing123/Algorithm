using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_559
    {


        public int MaxDepth(Node root)
        {

            if (root == null) return 0;
            int count = 1;
            for (int i = 0; i < root.children.Count; i++)
            {
                count = Math.Max(count, 1 + MaxDepth(root.children[i]));
            }
            return count;
        }

        //int max = 0;
        //public int MaxDepth(Node root)
        //{

        //    if (root == null) return 0;
        //    int count = 1;
        //    for (int i = 0; i < root.children.Count; i++)
        //    {
        //        count = Math.Max(count, 1 + MaxDepth(root.children[i]));
        //    }
        //    return count;
        //    Helper(root);
        //    return max;
        //}

        //public int Helper(Node node)
        //{
        //    if (node == null) return 0;
        //    int count = 1;
        //    for (int i = 0; i < node.children.Count; i++)
        //    {
        //        count = Math.Max(count, count + Helper(node.children[i]));
        //    }
        //    max = Math.Max(max, count);
        //    return count;

        //}
    }
}

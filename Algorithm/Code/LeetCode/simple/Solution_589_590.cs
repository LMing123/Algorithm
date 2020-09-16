using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_589_590 
    {
        public IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();
            var list = new List<int>();
            list.Add(root.val);
            for(int i=0;i<root.children.Count;i++)
            {
                var r = Preorder(root.children[i]);
                if (r != null && r.Count > 0) list.AddRange(r);
            }
            return list;
        }


        public IList<int> Postorder(Node root)
        {
            if (root == null) return new List<int>();
            var list = new List<int>();
            for (int i = 0; i < root.children.Count; i++)
            {
                var r = Postorder(root.children[i]);
                if (r.Count > 0) list.AddRange(r);
            }
            list.Add(root.val);
            return list;
        }
    }
}

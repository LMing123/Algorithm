using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_414
    {
        public class Node
        {
            public Node(int i) => val = i;
            public int val;
            public Node left;
            public Node right;

        }
        public int ThirdMax(int[] nums)
        {
            if (nums.Length < 3) return nums.Max();
            HashSet<int> sets = new HashSet<int>();
            Node root = new Node(int.MinValue);
            root.left = new Node(int.MinValue);
            root.right = new Node(int.MinValue);
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (sets.Contains(num)) continue;
                else sets.Add(num);
                if (num > root.val)
                {
                    root.right.val = root.left.val;
                    root.left.val = root.val;
                    root.val = num;
                }
                else if (num >= root.left.val)
                {
                    root.right.val = root.left.val;
                    root.left.val = num;
                }
                else if (num >= root.right.val) root.right.val = num;
                else { continue; }
            }
            if (sets.Count < 3) return sets.Max();
            else return root.right.val;
        }
    }
}

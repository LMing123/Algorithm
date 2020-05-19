using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_237
    {
        public static void DeleteNode(ListNode node)
        {
            if (node == null) return;
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

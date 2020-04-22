using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
   public class Solution_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            while(head!=null&&head.val==val)
            {
                head = head.next;
            }
            var node = head;
            var preNode = head;
            while(node != null)
            {
                if (node.val == val)
                {
                    preNode.next = node.next;                   
                }
                else
                {
                    preNode = node;
                }
                node = node.next;

            }
            return head;
        }
    }
}

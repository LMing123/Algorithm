using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
   public  class Solution_160
    {
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            ListNode p1 = headA;
            ListNode p2 = headB;
            while(p1!=p2)
            {
                p1 = p1 == null ? headB : p1.next;
                p2 = p2 == null ? headA : p2.next;
            }
            return p1;

        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            Dictionary<ListNode, int> dic = new Dictionary<ListNode, int>();
            var head = headA;
            while(head!=null)
            {
                dic.Add(head, 0);
                head = head.next;
            }
            head = headB;
            while(head != null && !dic.ContainsKey(head))
            {
                dic.Add(head, 0);
                head = head.next;
            }
            return head;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_206
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            var rear = head;
            var mid = head?.next;
            var front = mid?.next;
            head.next = null;
            while (mid != null)
            {
                mid.next = rear;
                rear = mid;
                mid = front;
                front = front?.next;

            }
            return rear;

        }
        public static ListNode ReverseList1(ListNode head)
        {
            if (head == null) return head;
            var result = head;

            while (result.next != null)
            {
                result = result.next;
            }

            Reverse(head);
            head.next = null;
            return result;
        }
        static ListNode Reverse(ListNode head)
        {
            if (head.next == null)
                return head;
            var node = Reverse(head.next);
            node.next = head;
            return head;
        }
    }
}

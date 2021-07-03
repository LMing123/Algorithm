using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_234
    {


        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            var slow = head;
            var fast = head;
            while(fast!=null&&fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            var curr = slow;
            ListNode prev = null;
            while(curr!=null)
            {
                var tem = curr;
                curr = curr.next;
                tem.next = prev;
                prev = tem;
            }
            while(head!=null&& prev != null)
            {
                if (head.val != prev.val) return false;
                head = head.next;
                prev = prev.next;
            }
            return true;
            
        }

        public static bool IsPalindrome1(ListNode head)
        {
           return _SpecialS(ref head, head);
        }

        private static bool _SpecialS(ref ListNode head, ListNode rear)
        {
            if (rear == null) return true;
            var result= _SpecialS(ref head, rear.next)&&rear.val==head.val;
            head = head.next;
            return result;
        }
    }
}

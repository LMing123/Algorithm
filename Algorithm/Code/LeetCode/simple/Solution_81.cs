using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{


    /// <summary>
    /// 83. 删除排序链表中的重复元素
    /// </summary>
    class Solution_81
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        
        public static ListNode Func(ListNode head)
        {
            if (head == null)
                return head;
            ListNode q = head;
            ListNode p = head.next;
            while(p!=null)
            {
                if (q.val == p.val)
                {
                    q.next = p.next;
                    p = q.next;
                }
                else
                {
                    q = p;
                    p = p.next;
                }
            }
            return head;
        }
    }
}

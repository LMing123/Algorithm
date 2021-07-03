using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 24. 两两交换链表中的节点
    /// </summary>
    public partial class Solution_21
    {
        public static ListNode ChangeTwoLinkListNode(ListNode head)
        {
            if (head == null)
                return head;
            if (head.next == null)
                return head;
            ListNode p = head;
            ListNode q = head.next;
            ListNode o = q;
            while (p != null && q != null)
            {
                p.next = q.next;
                q.next = p;
                ListNode t = p;
                p = p.next;
                if (p == null)
                    break;
                if (p.next == null)
                    break;
                q = p.next;
                t.next = q;

            }
            return o;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 21. 合并两个有序链表
    /// </summary>
    public partial class Solution_21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            if (l1 == null && l2 == null)
            {
                return head;
            }
            else if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            if (l1.val <= l2.val)
            {
                head = l1;
            }
            else
            {
                head = l2;
            }
            while (l1 != null && l2 != null)
            {
                ListNode tem1 = l1.next;
                ListNode tem2 = l2.next;
                if (l1.val <= l2.val)
                {
                    l1.next = l2;
                    l1 = tem1;
                }
                else
                {
                    l2.next = l1;
                    l2 = tem2;
                }

            }
            return head;
        }
    }
}

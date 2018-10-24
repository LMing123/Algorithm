using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    /// <summary>
    /// 19. 删除链表的倒数第N个节点
    /// </summary>
    class Solution_19
    {
        public static ListNode Fuck(ListNode head, int n)
        {
            ListNode node = head;  ///感觉没写好
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            Console.WriteLine(count);
            head = node;

            int j = 0;
            while (head != null)
            {
                if (count - n == 0)
                {
                    head = head.next;
                    node = head;
                    break;
                }
                ListNode tem = head;
                head = head.next;
                j++;
                if (j == count - n)
                {
                    tem.next = head.next;
                    break;
                }
            }
            return node;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_155
    {
        Node current;
        int min = int.MaxValue;
        public Solution_155()
        {
            
        }

        public void Push(int x)
        {
            if(current==null)
            {
                current = new Node(x, x, null);
                min = x;
            }
            else
            {
                min = Math.Min(x, current.min);
                var tem = new Node(x,min,current);
                current = tem;
            }
        }

        public void Pop()
        {
           current= current==null? null: current.next; 
        }

        public int Top()
        {
          return current==null?0: current.val;  ///竟然为空的时候不让抛异常 - -
        }

        public int GetMin()
        {
            return current == null ? 0 : current.min;
        }

        class Node
        {
            public int val;
            public Node next;
            public int min;
            public Node(int val,int min,Node node)
            {
                this.val = val;
                this.min = min;
                next = node;
            }
        }
    }
}

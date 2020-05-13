using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_225
    {
        Queue<int> queue;
        Queue<int> tem_queue;
        /** Initialize your data structure here. */
        public Solution_225()
        {
            queue = new Queue<int>();
            tem_queue = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            if (queue.Count == 0) queue.Enqueue(x);
            else
            {
                while(queue.Count!=0)
                {
                    tem_queue.Enqueue(queue.Dequeue());
                }
                queue.Enqueue(x);
                while (tem_queue.Count != 0)
                {
                    queue.Enqueue(tem_queue.Dequeue());
                }
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
           return queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
          return  queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
           return queue.Count == 0 ? true : false;
        }
    }
}

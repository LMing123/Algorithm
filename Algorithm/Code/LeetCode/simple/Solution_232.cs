using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    public class Solution_232
    {
        Stack<int> mainStack;
        Stack<int> temStack;
        /** Initialize your data structure here. */
        public Solution_232()
        {
            mainStack = new Stack<int>();
            temStack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            mainStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (temStack.Count != 0)
            {
                return temStack.Pop();
            }
            while (mainStack.Count > 0)
            {
                temStack.Push(mainStack.Pop());
            }
            return temStack.Pop();

        }

        /** Get the front element. */
        public int Peek()
        {
            if (temStack.Count != 0)
            {
                return temStack.Peek();
            }
            while (mainStack.Count > 0)
            {
                temStack.Push(mainStack.Pop());
            }
            return temStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return mainStack.Count == 0 && temStack.Count == 0 ? true : false;
        }
    }
}

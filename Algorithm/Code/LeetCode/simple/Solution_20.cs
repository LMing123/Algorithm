using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 20. 有效的括号
    /// </summary>
    public partial class Solution_20
    {
        public static bool Func(string s)
        {
            bool flag = true;
            Stack<char> stack = new Stack<char>();
            foreach(var i in s)
            {
                if(i=='('||i=='{'||i=='[')
                {
                    stack.Push(i);
                }
                if(i == ')' || i == '}' || i == ']')
                {
                    if(stack.Count==0)
                    {
                        return false;
                    }
                    char temp = stack.Pop();
                    if(i==')'&&temp!='(')
                    {
                        return false;
                    }
                    if(i==']'&&temp!='[')
                    {
                        return false;

                    }
                    if (i=='}'&&temp!='{')
                    {
                        return false;
                    }
                }
            }
            if(stack.Count!=0)
            {
                return false;
            }
            return flag;
        }
    }
}

using System.Collections.Generic;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 32. 最长有效括号
    /// 给定一个只包含 '(' 和 ')' 的字符串，找出最长的包含有效括号的子串的长度。
    /// </summary>
    public class Solution_32
    {
        public static int Fuck(string s)
        {
            Stack<char> shit = new Stack<char>();
            Stack<char> s_shit = new Stack<char>();

            int result = 0;
            int count = 0;
            for (int i = 0; i < s.Length; )
            {
                bool fail = false;
                if (s[i] == '(')
                {
                    shit.Push(s[i]);
                    i++;
                }
                else
                {
                    while(i<s.Length)
                    {
                        if(s[i]=='(')
                        {
                            //count =0;
                            break;
                        }
                        if(shit.Count==0)
                        {
                            i++;
                            fail = true;
                            break;
                        }
                        shit.Pop();
                        count += 2;
                        i++;
                    }
                }


                if (result < count)
                    result = count;
                if (fail)
                    count = 0;

            }
            return result;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_205
    {
        //映射 
        public static bool IsIsomorphic2(string s, string t)
        {
            int[] Func1 = new int[128];
            int[] Func2 = new int[128];
            for(int i=0;i<s.Length;i++)
            {
                if(Func1[ s[i]]!=Func2[t[i]])
                {
                    return false;
                }
                else
                {
                    if(Func1[s[i]]==0)
                    {
                        Func1[s[i]] =i+ 1;
                        Func2[t[i]] =i+ 1;
                    }
                }
            }
            return true;
        }
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> Func1 = new Dictionary<char, char>();
            Dictionary<char, char> Func2 = new Dictionary<char, char>();
            int length = s.Length;
            for(int i=0;i<length;i++)
            {
                if(Func1.ContainsKey(s[i]))
                {
                    if (Func1[s[i]] != t[i])
                        return false;
                }               
                else
                {
                    Func1.Add(s[i], t[i]);
                }
                if (Func2.ContainsKey(t[i]))
                {
                    if (Func2[t[i]] != s[i])
                        return false;
                }
                else
                {
                    Func1.Add(t[i], s[i]);
                }

            }
            return true;
        }
    }
}

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
            int[] fuck1 = new int[128];
            int[] fuck2 = new int[128];
            for(int i=0;i<s.Length;i++)
            {
                if(fuck1[ s[i]]!=fuck2[t[i]])
                {
                    return false;
                }
                else
                {
                    if(fuck1[s[i]]==0)
                    {
                        fuck1[s[i]] =i+ 1;
                        fuck2[t[i]] =i+ 1;
                    }
                }
            }
            return true;
        }
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> fuck1 = new Dictionary<char, char>();
            Dictionary<char, char> fuck2 = new Dictionary<char, char>();
            int length = s.Length;
            for(int i=0;i<length;i++)
            {
                if(fuck1.ContainsKey(s[i]))
                {
                    if (fuck1[s[i]] != t[i])
                        return false;
                }               
                else
                {
                    fuck1.Add(s[i], t[i]);
                }
                if (fuck2.ContainsKey(t[i]))
                {
                    if (fuck2[t[i]] != s[i])
                        return false;
                }
                else
                {
                    fuck1.Add(t[i], s[i]);
                }

            }
            return true;
        }
    }
}

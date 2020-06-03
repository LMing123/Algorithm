using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_345
    {
        public static string ReverseVowels(string s)
        {
            if (s.Length == 0 || s.Length == 1) return s;
            char[] list = new char[s.Length];
            var o = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var i = 0;
            var j = s.Length - 1;
            while (i <= j)
            {
                if (o.Contains(s[i]))
                {
                    while (!o.Contains(s[j]) && i < j && j >= 0)
                    {
                        list[j] = s[j];
                        j--;
                    }
                    list[i] = s[j];
                    list[j] = s[i];
                    i++;
                    j--;
                }
                else
                {
                    list[i] = s[i];
                    i++;

                }

            }
            return new string(list);

        }
        public static string ReverseVowels1(string s)
        {
            if (s.Length == 0||s.Length==1) return s;
            char[] list = s.ToArray();
            var o = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var i = 0;
            var j = list.Length - 1;
            while(i<j)
            {
                if(o.Contains(list[i]))
                {
                    while (!o.Contains(list[j]) && i < j && j >= 0)
                    {
                        j--;
                    }
                    char k = list[i];
                    list[i] = list[j];
                    list[j] = k;
                    i++;
                    j--;
                }
                i++;             
               
            }
            return new string(list);

        }
    }
}

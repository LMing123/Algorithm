using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_290
    {
        public static bool WordPattern(string pattern, string str)
        {
            var compare = str.Split(' ');
            if (compare.Length != pattern.Length) return false;
            var list1 = new int[9999];
            var list2 = new int[9999];
            for (int i = 0; i < pattern.Length; i++)
            {
                int tem = Calc(compare[i]);
                if (list1[pattern[i]] != list2[tem]) return false;
                else
                {
                    list1[pattern[i]] = i + 1;
                    list2[tem] = i + 1;
                }
            }
            return true;
        }

        public static int Calc(string s)
        {
            int result = 0;
            for(int i=0;i<s.Length;i++)
            {
                result += s[i];
            }
            return result;
        }
        public static bool WordPattern1(string pattern, string str)
        {
            var compare = str.Split(' ');
            if (compare.Length != pattern.Length) return false;

            Dictionary<char, int> list1 = new Dictionary<char, int>();
            Dictionary<string, int> list2 = new Dictionary<string, int>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (list1.ContainsKey(pattern[i]))
                {
                    list1[pattern[i]] += i + 1;
                }
                else
                {
                    list1[pattern[i]] = i + 1;
                }
                if (list2.ContainsKey(compare[i]))
                {
                    list2[compare[i]] += i + 1;
                }
                else
                {
                    list2[compare[i]] = i + 1;
                }
                if (list1[pattern[i]] != list2[compare[i]]) return false;



            }
            return true;
        }
    }
}

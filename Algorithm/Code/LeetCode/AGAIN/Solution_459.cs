using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Algorithm.Code.LeetCode.FUCK
{
    class Solution_459
    {

        public static bool RepeatedSubstringPattern(string s)
        {
            if (s.Length == 0 || s.Length == 1) return false;
            StringBuilder sb1 = new StringBuilder(s.Length * 2 - 1);
            sb1.Append(s, 1, s.Length - 1);
            sb1.Append(s, 0, s.Length - 1);

            return sb1.ToString().Contains(s);

            //   if (s.Length == 0 || s.Length == 1) return false;
            //         StringBuilder sb1 = new StringBuilder(s.Length*2-1);
            //         sb1.Append(s, 1, s.Length - 1);
            //         sb1.Append(s);

            //        return sb1.ToString().IndexOf(s)+1 != s.Length;

        }

        //public static bool RepeatedSubstringPattern(string s)
        //{
        //    if (s.Length == 0||s.Length==1) return false;
        //    StringBuilder sb1 = new StringBuilder();
        //    StringBuilder sb2 = new StringBuilder();
        //    for (int i=1;i<=s.Length/2;i++)
        //    {

        //        sb1.Append(s, 0, i);
        //        sb2.Append(s, i, s.Length - i);

        //        if (sb2.Append(sb1).ToString() == s) return true;
        //        sb1.Clear();
        //        sb2.Clear();
        //    }
        //    return false;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_541
    {
        public string ReverseStr(string s, int k)
        {
            var content = s.ToCharArray();
            for(int i=0;i<s.Length;i+=2*k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, s.Length - 1);
                while(left<right)
                {
                    var tem = content[left];
                    content[left] = content[right];
                    content[right] = tem;
                }
            }
            return new string(content);
        }
        //public string ReverseStr(string s, int k)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    int i = 0;
        //    while (i + 2 * k < s.Length)
        //    {

        //        sb.Append(ReverseHelper(s.Substring(i, k)));
        //        sb.Append(s.Substring(i + k, k));
        //        i += 2 * k;
        //    }
        //    if (i + 2 * k >= s.Length && i + k < s.Length)
        //    {
        //        sb.Append(ReverseHelper(s.Substring(i, k)));
        //        i += k;
        //        sb.Append(s.Substring(i, s.Length - i));
        //    }else  if (i + k > s.Length - 1)
        //    {
        //        sb.Append(ReverseHelper(s.Substring(i, s.Length - i)));
        //    }


        //    return sb.ToString();
        //}

        //private string ReverseHelper(string s)
        //{
        //    StringBuilder sb = new StringBuilder(s);
        //    for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        //    {
        //        var tem = sb[i];
        //        sb[i] = sb[j];
        //        sb[j] = tem;
        //    }
        //    return sb.ToString();
        //}
    }
}

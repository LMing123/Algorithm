using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_557
    {
        public string ReverseWords(string s)
        {
            if (s.Length == 0 || string.IsNullOrEmpty(s)) return s;
            var content = s.ToCharArray();


            int begin = NextNoSpace(ref content, 0);
            int index = begin + 1;
            while (index<content.Length)
            {     
                while ( index < content.Length&&content[index] != ' ')
                {
                    index++;
                }
                ExchangeWord(ref content, begin, index - 1);
                begin= NextNoSpace(ref content, index);
                index++;
            }
            return new string(content);
        }

        int NextNoSpace(ref char[] content,int index)
        {
            for(int i=index;i<content.Length;i++)
            {
                if (content[i] != ' ') return i;
            }
            return content.Length;
        }
        void ExchangeWord(ref char[] content,int begin,int end)
        {
            while(begin<end)
            {
                var tem = content[begin];
                content[begin] = content[end];
                content[end] = tem;
                begin++;
                end--;
            }
        }
    }
}

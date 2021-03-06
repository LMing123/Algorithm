﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code
{
    class RecursionArrange
    {
        public static List<string> Func(List<string> s)
        {
            return SpecialS(s);
        }

        static List<string> SpecialS(List<string> s)
        {
            if (s.Count == 1)
                return s;
            List<string> result = new List<string>();
            for (int i = 0; i < s.Count; i++)
            {
                // List<string> tem = new List<string>(s);
                //tem.RemoveAt(i);
                var tem = s.Where((x, y) => y != i).ToList();
                var query=SpecialS(tem);
                foreach(var word in query)
                {
                    var tem_word = s[i] + word;
                    result.Add(tem_word);
                }
            }
            return result;
        }
    }
}

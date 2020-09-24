using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_599
    {
        Dictionary<string, int> list = new Dictionary<string, int>();

        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var sortList = list1.Length > list2.Length ? list2 : list1;
            var sortLength = Math.Min(list1.Length , list2.Length);
            for (int i = 0; i < sortLength;i++)
            {
                list.Add(sortList[i], i);
            }

         
            if (list1.Length==sortLength)
            {
                return Helper(list2);
            }
            else
            {
                return Helper(list1);

            }
        }


        public string[] Helper(string[] content)
        {
            int min = 2020;
            List<string> result = new List<string>();

            for (int i = 0; i < content.Length; i++)
            {
                if (!list.ContainsKey(content[i])) continue;

                if ( i + list[content[i]] < min)
                {
                    result.Clear();
                    result.Add(content[i]);
                    min = i + list[content[i]];
                }
                else if ( i + list[content[i]] == min)
                {
                    result.Add(content[i]);
                }
             }
            return result.ToArray();
        }
    }
}

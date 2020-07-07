using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
   public class Solution_119
    {
        public static IList<int> GetRow(int rowIndex)// (j - 1 < 0 ? 0 : lists[i - 1][j - 1])
        {
            rowIndex += 1;
            if (rowIndex == 0) return new List<int>();
            var lists = new List<IList<int>>();
            lists.Add(new List<int> { 1 });
            if (rowIndex == 1) return lists[rowIndex-1];
            

            for (int i = 2; i <= rowIndex; i++)
            {
                var list = new int[i];
                for (int j = 0; j < i; j++)
                {
                    if (j >= lists[i - 2].Count || j - 1 < 0)
                    {
                        if (j - 1 < 0)
                        {
                            list[j] = 0 + lists[i - 2][j];
                        }
                        else
                        {
                            list[j] = (lists[i - 2][j - 1]) + 0;
                        }

                    }
                    else
                    {
                        list[j] = lists[i - 2][j - 1] + lists[i - 2][j];
                    }
                }
                lists.Add(list);
            }
            return lists[rowIndex-1];
        }
    }
}

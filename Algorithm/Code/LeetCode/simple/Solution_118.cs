using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
    /// 输入: 5
    /// 输出:
    /// [
    /// [1],
    /// [1,1],
    /// [1,2,1],
    /// [1,3,3,1],
    /// [1,4,6,4,1]
    /// ]
    /// </summary>
    public class Solution_118
    {
        public static IList<IList<int>> Generate(int numRows)// (j - 1 < 0 ? 0 : lists[i - 1][j - 1])
        {
            var lists = new List<IList<int>>();
            if (numRows == 0) return lists;

            lists.Add(new List<int> { 1 });
            
            if (numRows == 1) return lists;
            for (int i = 2; i <= numRows; i++)
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
            return lists;
        }
    }
}

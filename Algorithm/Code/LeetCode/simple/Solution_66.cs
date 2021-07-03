using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode
{
    /// <summary>
    /// 66. 加一
    /// 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
    /// 最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。
    /// 你可以假设除了整数 0 之外，这个整数不会以零开头。
    /// 输入: [1,2,3]
    /// 输出: [1,2,4]
    /// </summary>
    class Solution_66
    {
        public static int[] Func(int[] digits)
        {
            List<int> result =new List<int>(digits);
            for (int i= result.Count-1;i>=0;i--)
            {
                if (result[i] + 1 > 9)
                {
                    result[i] = 0;
                    if (i == 0)
                        result.Insert(0, 1);
                }
                else
                {
                    result[i] = result[i] + 1;
                    break;
                }
            }
            return result.ToArray();
        }
    }
}

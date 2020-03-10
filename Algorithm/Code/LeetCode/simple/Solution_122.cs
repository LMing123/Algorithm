using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 
    /// 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
    /// 设计一个算法来计算你所能获取的最大利润。你可以尽可能地完成更多的交易（多次买卖一支股票）。
    /// 注意：你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）。
    /// 
    /// 输入: [7,1,5,3,6,4]
    /// 输出: 7
    /// 解释: 在第 2 天（股票价格 = 1）的时候买入，在第 3 天（股票价格 = 5）的时候卖出, 这笔交易所能获得利润 = 5-1 = 4 。
    /// 随后，在第 4 天（股票价格 = 3）的时候买入，在第 5 天（股票价格 = 6）的时候卖出, 这笔交易所能获得利润 = 6-3 = 3 。
    /// 来源：力扣（LeetCode）链接：https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii
    /// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    /// </summary>
    public class Solution_122
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for(int i=0;i<prices.Length-1;i++)
            {
                int tem = prices[i + 1] - prices[i];
                if (tem > 0) max += tem;
            }
            return max;
        }

        // too complex too
        //public static int MaxProfit(int[] prices)
        //{
        //    int length = prices.Length;
        //    int[,] table = new int[length, length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        for (int j = 0; j < length; j++)
        //        {
        //            if (j < i || j == i) continue;
        //            table[i, j] = prices[j] - prices[i];
        //        }
        //    }
        //    int max = 0;
        //    max = MaxHelper(table, (int)Math.Sqrt(table.Length), 0,1);

        //    return max;
        //}

        //public static int MaxHelper(int[,] list, int length, int start,int end)
        //{
        //    int max = 0;
        //    if (start > length || start + 1 > length) return 0;
        //    for (int i = start; i < length - 1; i++)
        //    {
        //        for (int j = end; j < length; j++)
        //        {

        //            if (j < i) continue;
        //            int result = list[i, j];
        //            if (result <= 0) continue;
        //            result += MaxHelper(list, length, j + 1,j+2);
        //            if (result > max) max = result;


        //        }
        //    }
        //    return max;
        //}


        //too much time complex
        //public static int MaxProfit(int[] prices)
        //{
        //    if (prices.Length == 1 || prices.Length == 0) return 0;

        //    int max = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            int result = 0;
        //            int tem = prices[j] - prices[i];
        //            if (tem > result)
        //            {
        //                result = tem;
        //                int[] vs = new int[prices.Length - j];
        //                Array.Copy(prices, j + 1, vs, 0, prices.Length - j - 1);
        //                result += MaxProfit(vs);
        //                if (result > max) max = result;
        //            }
        //        }

        //    }
        //    return max;
        //}



    }
}

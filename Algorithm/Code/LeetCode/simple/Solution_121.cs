using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
    /// 如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。
    /// 注意你不能在买入股票前卖出股票。
    /// 示例 1:
    /// 输入: [7,1,5,3,6,4]
    /// 输出: 5
    /// 解释: 在第 2 天（股票价格 = 1）的时候买入，在第 5 天（股票价格 = 6）的时候卖出，最大利润 = 6-1 = 5 。
    /// 注意利润不能是 7-1 = 6, 因为卖出价格需要大于买入价格。
    /// 来源：力扣（LeetCode）链接：https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock
    /// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    /// </summary>
    public class Solution_121
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            if (prices.Length == 0) return max;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                // int tem = prices[i] - min;
                //  if (tem > max) max = tem;
                max = Math.Max(prices[i] - min, max);
                min=Math.Min(prices[i], min);
            }
            return max;
        }
        //public static int MaxProfit(int[] prices)
        //{
        //    int max = 0;
        //    for(int i=0;i<prices.Length;i++)
        //    {
        //        for(int j=i+1;j<prices.Length;j++)
        //        {
        //            int tem = prices[j] - prices[i];
        //            if(tem>max) max=tem;
        //        }
        //    }
        //    return max;
        //}
    }
}

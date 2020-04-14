using System;
using System.Diagnostics;

namespace BestTimeToBuyAndSellStocks
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            // var maxProfit = int.MinValue;
            //
            // for (int i = 0; i < prices.Length; i++)
            // {
            //     for (int j = i+1; j < prices.Length; j++)
            //     {
            //         if (prices[j] - prices[i] > 0)
            //         {
            //             maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
            //         }
            //     }
            // }
            //
            // if (maxProfit < 0)
            // {
            //     return 0;
            // }
            //
            // return maxProfit;#

            var minPrice = int.MaxValue;
            var maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    if (prices[i] - minPrice > maxProfit)
                    {
                        maxProfit = prices[i] - minPrice;
                    }
                }
            }

            return maxProfit;
        }
    }
}
using System;

namespace LeetCode.DynamicProgramming
{
    public class BuySellStock : IBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            var priceSoFor = 0;
            var priceEndingHere = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                priceEndingHere += prices[i] - prices[i-1];
                if (priceEndingHere < 0)
                    priceEndingHere = 0;

                if (priceSoFor < priceEndingHere)
                    priceSoFor = priceEndingHere;
            }

            return priceSoFor;
        }
    }
}
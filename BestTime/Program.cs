using System;

namespace BestTime
{
    class Program
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
            {
                return 0;
            }
            int index1 = 0;
            int diff = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int tempDiff = prices[i] - prices[index1];
                if (prices[index1] > prices[i])
                {
                    index1 = i;
                }
                else if (tempDiff > diff)
                {
                    diff = tempDiff;
                }
            }
            return diff;
        }
    }
}
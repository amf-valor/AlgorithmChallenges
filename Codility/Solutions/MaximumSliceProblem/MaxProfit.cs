using System;

namespace AlgorithmChallenges.Codility.Solutions.MaximumSliceProblem
{
    /// <summary>
    /// Lesson 9 - MaxProfit
    /// </summary>
    public class MaxProfit
    {
        public int Calculate(int[] A)
        {
            int maxProfit = 0;
            int minPrice = 200000;
            
            foreach (int price in A)
            {
                minPrice = Math.Min(price, minPrice);
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }

            return maxProfit;
        }
    }
}

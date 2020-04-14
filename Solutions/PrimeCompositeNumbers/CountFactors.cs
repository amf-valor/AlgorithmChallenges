using System;

namespace AlgorithmChallenges.Codility.Solutions.PrimeCompositeNumbers
{
    /// <summary>
    /// Lesson 10 - CountFactors
    /// </summary>
    public class CountFactors
    {
        public int Count(int N)
        {
            int counter = 0;
            int square = (int) Math.Sqrt(N);

            for (int i = 1; N / i > square; i++)
            {
                if (N % i == 0)
                {
                    counter += 2;
                }
            }

            if (square * square == N)
            {
                counter++;
            }

            return counter;
        }
    }
}

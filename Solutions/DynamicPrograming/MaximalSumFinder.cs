using System;

namespace AlgorithmChallenges.Codility.Solutions.DynamicPrograming
{
    /// <summary>
    /// Lesson 15 - Number Solitaire
    /// </summary>
    public class MaximalSumFinder
    {
        public int Find(int[] A)
        {
            int[] maxs = new int[A.Length];
            maxs[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                maxs[i] = maxs[i - 1];
                 
                for (int diceFace = 2; diceFace <= 6; diceFace++)
                {
                    if (i >= diceFace)
                    {
                        maxs[i] = Math.Max(maxs[i], maxs[i - diceFace]);
                    }
                    else
                    {
                        break;
                    }
                }
                maxs[i] += A[i];
            }

            return maxs[A.Length - 1];
        }
    }
}

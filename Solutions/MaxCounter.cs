using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class MaxCounter
    {
        public int[] Count(int N, int[] A)
        {
            if (N < 1 || N > 100000)
                throw new ArgumentException();

            int[] result = new int[N];
            int maxCounter = 0;
            int baseValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int index = A[i];

                if (index >= 1 && index <= N)
                {
                    index--;

                    if (result[index] < baseValue)
                    {
                        result[index] = baseValue + 1;
                    }
                    else
                    {
                        result[index]++;
                    }

                    if (result[index] > maxCounter)
                    {
                        maxCounter = result[index];
                    }
                }
                else if (index == N + 1)
                {
                    baseValue = maxCounter;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            for (int j = 0; j < result.Length; j++)
            {
                result[j] = Math.Max(baseValue, result[j]);
            }

            return result;
        }
    }
}

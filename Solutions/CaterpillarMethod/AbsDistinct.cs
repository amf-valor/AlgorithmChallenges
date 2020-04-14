using System;

namespace AlgorithmChallenges.Codility.Solutions.CaterpillarMethod
{

    /// <summary>
    /// Lesson 15 - AbsDistinct
    /// </summary>
    public class AbsDistinct
    {
        public int Count(int[] A)
        {
            int length = A.Length;
            int tail = 0;
            int head = length - 1;
            int distinctCounter = 1;
            long maxValue = Math.Max(Math.Abs((long)A[head]), Math.Abs((long)A[tail]));

            while (tail <= head)
            {
                long tailValue = Math.Abs((long)A[tail]);
                long headValue = Math.Abs((long)A[head]);

                if (tailValue == maxValue)
                {
                    tail++;
                    continue;
                }

                if (headValue == maxValue)
                {
                    head--;
                    continue;
                }

                if (tailValue >= headValue)
                {
                    maxValue = tailValue;
                    tail++;
                }
                else
                {
                    maxValue = headValue;
                    head--;
                }

                distinctCounter++;
            }

            return distinctCounter;
        }
    }
}

using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions.PrimeCompositeNumbers
{
    /// <summary>
    /// Lesson 10 - Peaks
    /// </summary>
    public class BlocksCounter
    {
        /// <summary>
        /// First we count the peaks and record the indexes 
        /// Second test smaller size of a block to the bigger, because how smaller is a block
        /// more blocks it can be divided. 
        /// Third Testing the blocks we divide each peakIndex by the block number if the result
        /// is equal it means the peak is inside of this block so we increment the block number and check.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Count(int[] A)
        {
            int N = A.Length;
            int blocks = 0;
            var peaks = new List<int>();

            if (N < 3)
            {
                return blocks;
            }

            for (int i = 1; i < N - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            if (peaks.Count > 0)
            {
                blocks++;

                for (int blocksCount = N - 1; blocksCount > 1; blocksCount--)
                {
                    if (N % blocksCount != 0)
                    {
                        continue;
                    }

                    int blockSize = N / blocksCount;
                    int blocksHasPeaks = 0;

                    foreach (int peak in peaks)
                    {
                        if (peak / blockSize == blocksHasPeaks)
                        {
                            blocksHasPeaks++;
                        }
                    }

                    if(blocksHasPeaks == blocksCount)
                    {
                        blocks = blocksCount;
                        break;
                    }
                } 
            }

            return blocks;
        }
    }
}

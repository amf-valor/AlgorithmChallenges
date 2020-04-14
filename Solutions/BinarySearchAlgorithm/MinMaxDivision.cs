using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.BinarySearchAlgorithm
{
    /// <summary>
    /// Lesson 14 - MinMaxDivision
    /// </summary>
    public class MinMaxDivision
    {
        /// <summary>
        /// we use binary search with predicate evaluation(greedily checking), the link bellow is a really good reference of explanation
        /// https://www.topcoder.com/community/competitive-programming/tutorials/binary-search/
        /// </summary>
        /// <param name="K"></param>
        /// <param name="M"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Minimize(int K, int M, int[] A) 
        {
            int maxSum = A.Sum();
            int minSum = A.Max();
            int minLargeSum = 0;

            if (K == 1) 
            {
                return maxSum;
            }

            if (K >= A.Length) 
            {
                return minSum;
            }

            while (minSum <= maxSum) 
            {
                int middleSum = (minSum + maxSum) / 2;

                if (HasEnoughBlocks(A, middleSum, K))
                {
                    minLargeSum = middleSum;
                    maxSum = middleSum - 1;
                }
                else 
                {
                    minSum = middleSum + 1;
                }
            }

            return minLargeSum;
        }

        private bool HasEnoughBlocks(int[] a, int middleSum, int k)
        {
            int blocks = k;
            int largeSum = 0;

            for (int i = 0; i < a.Length; i++) 
            {
                largeSum += a[i];

                if(largeSum > middleSum) 
                {
                    blocks--;
                    largeSum = a[i];
                }

                if(blocks == 0) 
                {
                    return false;
                }
            }

            return true;
        }
    }
}

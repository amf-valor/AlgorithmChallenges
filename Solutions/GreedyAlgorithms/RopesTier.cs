using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.GreedyAlgorithms
{
    /// <summary>
    /// Lesson 16 - TieRopes
    /// </summary>
    public class RopesTier
    {
        /// <summary>
        /// Greedy solution
        /// </summary>
        /// <param name="K"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int GetTied(int K, int[] A) 
        {
            if (K == 1) 
            {
                return A.Length;
            }

            int maxTiedRopes = 0;

            for (int i = 0; i < A.Length; i++) 
            {
                int currentSum = 0;

                while (currentSum < K && i < A.Length)
                {
                    currentSum += A[i];
                    i++;
                }

                if (currentSum >= K) 
                {
                    maxTiedRopes++;
                }

                i--;
            }

            return maxTiedRopes;
        }

        /// <summary>
        /// Another possible solution which is shorter
        /// </summary>
        /// <param name="K"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int K, int[] A)
        {
            int maxTiedRopes = 0;
            int ropeLength = 0;

            foreach (int rope in A)
            {
                ropeLength += rope;

                if (ropeLength >= K)
                {
                    maxTiedRopes++;
                    ropeLength = 0;
                }
            }

            return maxTiedRopes;
        }
    }
}

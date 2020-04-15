using System;

namespace AlgorithmChallenges.Codility.Solutions.MaximumSliceProblem
{
    /// <summary>
    /// Lesson 9 - MaxDoubleSliceSum
    /// </summary>
    public class MaxDoubleSliceSum
    {
        /// <summary>
        /// We can still using kadane's algorithm recording all sums from starting index 1 to Length -2 and reverse(Length -2 to 1)
        /// After calculate all of them we can loop through both array of sums grabing the max of Startings[i - 1] + Endings[i + 1](Kadane's style)
        /// As a double slice definition we do not need to worry about the values into first and last position 
        /// https://en.wikipedia.org/wiki/Maximum_subarray_problem
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Calculate(int[] A)
        {
            if (A.Length == 3)
                return 0;

            int[] fromStartingSums = new int[A.Length];
            int[] fromEndingSums = new int[A.Length];
            int maxSum = 0;

            for (int i = 1; i < A.Length - 1; i++)
            {
                fromStartingSums[i] = Math.Max(0, fromStartingSums[i - 1] + A[i]); 
            }

            for (int i = A.Length - 2; i > 0 ; i--)
            {
                fromEndingSums[i] = Math.Max(0, fromEndingSums[i + 1] + A[i]);
            }

            for (int i = 1; i < A.Length - 1; i++)
            {
                maxSum = Math.Max(maxSum, fromStartingSums[i - 1] + fromEndingSums[i + 1]);
            }

            return maxSum;
        }
    }
}

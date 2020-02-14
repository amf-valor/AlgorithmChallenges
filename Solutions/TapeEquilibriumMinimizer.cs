using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class TapeEquilibriumMinimizer
    {
        public int Minimize(int[] A)
        {
            int rigthSum = A.Sum();
            int leftSum = 0;
            List<int> diffs = new List<int>();

            for (int p = 1; p < A.Length; p++)
            {
                leftSum += A[p - 1];
                rigthSum -= A[p - 1];
                diffs.Add(Math.Abs(leftSum - rigthSum));
            }

            return diffs.Min();
        }
    }
}

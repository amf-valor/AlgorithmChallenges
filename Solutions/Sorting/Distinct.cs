using System;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Sorting
{
    public class Distinct
    {
        public int Get(int[] A)
        {
            if (A.Length == 0)
                return 0;

            int counter = 1;
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                int nextPosition = i + 1;

                if (nextPosition < A.Length && A[i] != A[nextPosition])
                {
                    counter++;
                }
            }

            return counter;
        }

        public int GetWithLambda(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}

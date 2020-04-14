using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions.CountingElements
{
    public class FrogRiverOne
    {
        public int Find(int X, int[] A)
        {
            HashSet<int> leaves = new HashSet<int>();
            int earliest = -1;
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X && !leaves.Contains(A[i]))
                {
                    leaves.Add(A[i]);
                }

                if (leaves.Count == X)
                {
                    earliest = i;
                    break;
                }
            }

            return earliest;
        }
    }
}

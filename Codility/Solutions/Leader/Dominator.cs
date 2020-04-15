using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Leader
{
    /// <summary>
    /// Lesson 8 - Dominator
    /// </summary>
    public class Dominator
    {
        public int Find(int[] A)
        {
            if (A.Length == 0)
                return -1;

            var sortedA = new List<int>(A);
            sortedA.Sort();
            int candidate = sortedA[A.Length / 2];
            var ocurrences = sortedA.Where(x => x == candidate).Count();

            if (ocurrences > A.Length / 2)
            {
                return Array.IndexOf(A, candidate);
            }
            else
            {
                return -1;
            }
        }
    }
}

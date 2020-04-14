using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Leader
{
    /// <summary>
    /// Lesson 8 - EquiLeader
    /// </summary>
    public class EquiLeader
    {
        /// <summary>
        /// Just need to know the number of ocuurencies of a leader, after this, loop through the collection
        /// counting hown many leaders you've seen (left ocurrencies) so, the right sequence will have leader occurencies - left ocurrencies
        /// Finally just check if both appears more than half in their sequences, if both are true you found an equileader.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Count(int[] A)
        {
            int equiLeaders = 0;
            var sortedA = new List<int>(A);
            sortedA.Sort();
            int candidateIndex = A.Length / 2;
            var leaderOcurrencies = sortedA.Where(x => x == sortedA[candidateIndex]).Count();

            if (leaderOcurrencies > candidateIndex)
            {
                int leader = sortedA[candidateIndex];
                int leftOcurrencies = 0;
                int rightOcurrencies = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == leader)
                    {
                        leftOcurrencies++;
                    }

                    rightOcurrencies = leaderOcurrencies - leftOcurrencies;

                    if (leftOcurrencies > ((i + 1) / 2) && rightOcurrencies > ((A.Length - (i + 1)) / 2))
                    {
                        equiLeaders++;
                    }
                }
            }

            return equiLeaders;
        }
    }
}

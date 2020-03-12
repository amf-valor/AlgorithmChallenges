using System;
using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class GenomicRangeQuery
    {
        /// <summary>
        /// Using jagged array [][] to mount a matrix such as:
        /// {0{1,0,0,0}, 1{0,1,0,0} ... }
        /// it's an array of array which has the string length to count whole string 
        /// and an inside array of 4 elements, because there are four factors.
        /// Each number of an insider array represents a counter of a factor
        /// the factors are already ordered, so counters are 0 = A, 1 = C, 2 = G, 3 = T
        /// After the matrix is done check which ocurrences have changed if the P is diferent from 0
        /// because wheather zero we just need which letter appeard first depending on the importance
        /// given by the factor
        /// </summary>
        /// <param name="S"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public int[] Query(string S, int[] P, int[] Q)
        {
            var factors = new Dictionary<char, int>()
            {
                {'A', 1},
                {'C', 2},
                {'G', 3},
                {'T', 4}
            };

            var result = new int[P.Length];
            var counters = new int[S.Length][];

            //count all ocurrences of each factor
            for (int i = 0; i < S.Length; i++)
            {
                counters[i] = new int[factors.Count];

                if (i > 0)
                {
                    Array.Copy(counters[i - 1], counters[i], factors.Count);
                }

                foreach (var factor in factors)
                {
                    if (S[i] == factor.Key)
                    {
                        counters[i][factor.Value - 1]++;
                        break;
                    }
                }
            }

            //compare the counters which has changed by (Q -P)
            for (int i = 0; i < P.Length; i++)
            {
                int from = P[i] - 1;

                for (int j = 0; j < factors.Count; j++)
                {
                    //this evaluate corner cases like {0,0} {5,5} {0,1}
                    //I mean queries which should compare only one prefixed sum array
                    int nucleotoideFrom = from >= 0 ? counters[from][j] : 0;
                    int nucleotoideTo = counters[Q[i]][j];

                    if (nucleotoideTo - nucleotoideFrom > 0)
                    {
                        result[i] = j + 1;
                        break;
                    }       
                }
            }

            return result;
        }
    }
}

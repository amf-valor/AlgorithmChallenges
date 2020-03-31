﻿using System;
using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions.SieveOfEratosthenes
{
    /// <summary>
    /// Lesson 11 - Count non divisible
    /// </summary>
    public class NonDivisiblesCounter
    {
        /// <summary>
        /// 1. Count the ocurrences of each element
        /// 2. Count all divisors for each element and subtract by the Length of array A to get nonDivisors
        /// 3. Add it to a cache since the elements can repeat and you do not need to calculate again.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] Count(int[] A)
        {
            int n = A.Length;
            var ocurrencesOfEach = CountOcurrencesOfEach(A);
            var nonDivisorsOfEach = new int[n];
            var nonDivisorsCache = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int element = A[i];

                if (nonDivisorsCache.ContainsKey(element))
                {
                    nonDivisorsOfEach[i] = nonDivisorsCache[element];
                }
                else
                {
                    int nonDivisorCounter = n - CountDivisorsPerOcurrence(element, ocurrencesOfEach);
                    nonDivisorsOfEach[i] = nonDivisorCounter;
                    nonDivisorsCache[element] = nonDivisorCounter;
                }
            }

            return nonDivisorsOfEach;
        }

        private int CountDivisorsPerOcurrence(int element, Dictionary<int, int> ocurrencesOfEach)
        {
            int square = (int)Math.Sqrt(element);
            int divisorCounter = 0;

            if (square * square == element && ocurrencesOfEach.ContainsKey(square))
            {
                divisorCounter += ocurrencesOfEach[square];
            }

            for (int divisor = 1; element / divisor > square; divisor++)
            {
                if (element % divisor == 0)
                {
                    if (ocurrencesOfEach.ContainsKey(divisor))
                    {
                        divisorCounter += ocurrencesOfEach[divisor];
                    }

                    if (ocurrencesOfEach.ContainsKey(element / divisor))
                    {
                        divisorCounter += ocurrencesOfEach[element / divisor];
                    }
                }
            }

            return divisorCounter;
        }

        private Dictionary<int, int> CountOcurrencesOfEach(int[] elements)
        {
            var result = new Dictionary<int, int>();

            for (int i = 0; i < elements.Length; i++)
            {
                int element = elements[i];

                if (result.ContainsKey(element))
                {
                    result[element]++;
                }
                else
                {
                    result.Add(element, 1);
                }
            }

            return result;
        }
    }
}

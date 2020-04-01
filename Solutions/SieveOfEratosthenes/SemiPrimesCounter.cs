namespace AlgorithmChallenges.Codility.Solutions.SieveOfEratosthenes
{
    /// <summary>
    /// Lesson 11 - Semi Primes
    /// </summary>
    public class SemiPrimesCounter
    {
        /// <summary>
        /// 1. Mount a sieve of erosthenes with least possible prime factor
        /// 2. Test every single element until N dividing by smallest prime if exist, whether result is zero it is considered semi prime
        /// because is divisible by two primes(fatorization technique). Store an acumulator of semi primes in this array(prefix sum)
        /// 3. Loop trough slices storing results of (P -1) - Q
        /// </summary>
        /// <param name="N"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public int[] Count(int N, int[] P, int[] Q)
        {
            int m = P.Length;
            int[] queriesResults = new int[m];
            int[] semiPrimesCounter = CountSemiPrimes(GetSmallestPrimes(N));

            for (int i = 0; i < m; i++)
            {
                int start = P[i] - 1;
                int end = Q[i];
                queriesResults[i] = semiPrimesCounter[end] - semiPrimesCounter[start];
            }

            return queriesResults;
        }

        private int[] GetSmallestPrimes(int to)
        {
            int[] smallestPrimes = new int[to + 1];
            int i = 2;

            while (i * i <= to)
            {
                if (smallestPrimes[i] == 0)
                {
                    int j = i * i;
                    
                    while (j <= to)
                    {
                        if (smallestPrimes[j] == 0)
                        {
                            smallestPrimes[j] = i;
                        }

                        j += i;
                    }
                }

                i++;
            }

            return smallestPrimes;
        }

        private int[] CountSemiPrimes(int[] smallestPrimes)
        {
            int length = smallestPrimes.Length;
            var semiPrimesCounter = new int[length];
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                int smallestPrime = smallestPrimes[i];
                
                if (smallestPrime > 0 && smallestPrimes[i / smallestPrime] == 0 )
                {
                    count++;
                }

                semiPrimesCounter[i] = count;
            }

            return semiPrimesCounter;
        }
    }
}

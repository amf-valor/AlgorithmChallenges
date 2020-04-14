namespace AlgorithmChallenges.Codility.Solutions.EuclideanAlgorithm
{
    /// <summary>
    /// Lesson 12 - Common Prime Divisors
    /// </summary>
    public class CommonPrimeDivisors
    {
        /// <summary>
        /// To count same set of primes we can use gcd because it will pass through all primes as fatorization
        /// After find the gcd we must divide the number by gcd consecutevelly this process can isolate the factor which not in
        /// subset of prime. For instance:
        /// 
        /// 1.gcd(30,10) = 10; 10/10 = 1
        /// 2.( gcd(10, 30) = 10; 30/10 = 3 ) ( gcd(3,10) = 1)
        /// 
        /// notice in the second step 3 is remaining so 30 and 10 do not contains same prime divisors. 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int Count(int[] A, int[] B)
        {
            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (HasSameSetOfPrimes(A[i], B[i]) && HasSameSetOfPrimes(B[i], A[i]))
                {
                    counter++;
                }
            }

            return counter;
        }

        private int CalculateGcdOf(int number1, int number2)
        {
            return number1 % number2 == 0 ? number2 : CalculateGcdOf(number2, number1 % number2);
        }

        private bool HasSameSetOfPrimes(int number1, int number2)
        {
            int gcd = CalculateGcdOf(number1, number2);

            while (gcd != 1)
            {
                number1 /= gcd;
                gcd = CalculateGcdOf(number1, gcd);
            }

            return number1 == 1;
        }
    }
}

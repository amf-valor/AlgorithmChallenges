using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class DivCounter
    {

        public int Count(int A, int B, int K)
        {
            if (A % K == 0)
            {
                return ((B - A) / K) + 1;
            }
            else {
                return (B / K) - (A / K);
            }
        }
    }
}

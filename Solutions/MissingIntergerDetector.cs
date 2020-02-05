using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class MissingIntergerDetector
    {
        public int Detect(int[] A)
        {
            int missingInteger = 1;

            if (A is null)
                return missingInteger;

            int[] sortedA = A;
            Array.Sort(sortedA);

            for (int i = 0; i < sortedA.Length; i++)
            {
                int currentValue = sortedA[i];

                if (currentValue <= 0)
                {
                    continue;
                }
                else if (currentValue == missingInteger)
                {
                    missingInteger++;
                }
            }

            return missingInteger;

        }
    }
}

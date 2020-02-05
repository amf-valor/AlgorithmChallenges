using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class ArrayRotator
    {
        public int[] Rotate(int[] A, int K)
        {
            int[] arrayToRotate = new int[A.Length];
            Array.Copy(A, arrayToRotate, A.Length);
            int[] arrayRotated = new int[A.Length];
            int count = 1;

            if (A.Length == K || K == 0)
                return A;

            while (count <= K)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    int position = (i + 1) == A.Length ? 0 : i + 1;
                    arrayRotated[position] = arrayToRotate[i];
                }

                Array.Copy(arrayRotated, arrayToRotate, arrayRotated.Length);
                count++;
            }

            return arrayRotated;
        }
    }
}

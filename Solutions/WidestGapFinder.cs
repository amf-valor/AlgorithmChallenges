using System;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class WidestGapFinder
    {
        public int Find(int[] X, int[] Y)
        {
            int[] sortedX = new int[X.Length];
            Array.Copy(X, sortedX, X.Length);
            Array.Sort(sortedX);
            int widestGap = 1;


            for (int i = 0; i < sortedX.Length; i++)
            {
                if (i + 1 == sortedX.Length)
                    break;

                int currentGap = Math.Abs(sortedX[i] - sortedX[i + 1]);

                if (currentGap > widestGap)
                {
                    widestGap = currentGap;
                }
            }

            return widestGap;
        }
    }
}

namespace AlgorithmChallenges.Codility.Solutions.PrefixSums
{
    /// <summary>
    /// lesson 5 prefixSums - MinAvgTwoSlice
    /// </summary>
    public class MinAvgTwoSlice
    {
        /// <summary>
        /// the slices are subsets of array with 2 or 3 elements, for example:
        /// in array  { 4, 2, 2, 5, 1, 5, 8 } valid slices are [0,1] [1,2] [1,2,3]
        /// that's because in a pair length only 2 matters but odd's length 2 and 3 matters for example 5 elements
        /// so if the minimum average is found in those minor subsets does not matter the bigger ones like [1,4] [0,5].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Find(int[] A)
        {
            int positionOfMinAvg = 0;
            double minAvg = double.MaxValue;

            if (A.Length == 2)
                return positionOfMinAvg;

            for(int i = 1; i < A.Length; i ++)
            {
                double sliceOfTwoAvg = (A[i - 1] + A[i]) / 2.0;

                if (sliceOfTwoAvg < minAvg)
                {
                    minAvg = sliceOfTwoAvg;
                    positionOfMinAvg = i - 1;
                }

                if (i + 1 < A.Length)
                {
                    double sliceOfThreeAvg = (A[i - 1] + A[i] + A[i + 1]) / 3.0;

                    if (sliceOfThreeAvg < minAvg)
                    {
                        minAvg = sliceOfThreeAvg;
                        positionOfMinAvg = i - 1;
                    }
                }
            }

            return positionOfMinAvg;
        }
    }
}

namespace AlgorithmChallenges.Codility.Solutions
{
    public class PermElemFinder
    {
        public int Find(int[] A)
        {
            if (A.Length == 0) return 1;

            long sumOfA = 0;

            foreach (int item in A)
            {
                sumOfA += item;
            }

            // add length + 2 because the range can reach N+1
            long fullSum = ((A.LongLength + 1) * (A.LongLength + 2)) / 2;

            return (int) (fullSum - sumOfA);
        }
    }
}

using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class PermutationChecker
    {
        public int Check(int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            foreach(int item in A)
            {
                if (set.Contains(item))
                {
                    return 0;
                }
                else if (item <= A.Length)
                {
                    set.Add(item);
                } 
            }

            return set.Count == A.Length ?  1 : 0;
        }
    }
}

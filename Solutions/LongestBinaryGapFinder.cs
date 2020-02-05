using System;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class LongestBinaryGapFinder
    {
        public int Find(int N)
        {
            return Convert.ToString(N, 2)
            .Trim('0').Split('1')
            .Max(x => x.Length);
        }
    }
}

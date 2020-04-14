using System;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Iterations
{
    /// <summary>
    /// Lesson 1 - Iterations
    /// </summary>
    public class BinaryGap
    {
        public int Find(int N)
        {
            return Convert.ToString(N, 2)
            .Trim('0').Split('1')
            .Max(x => x.Length);
        }
    }
}

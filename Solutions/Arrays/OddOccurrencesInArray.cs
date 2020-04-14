using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Arrays
{
    /// <summary>
    /// Lesson 2 - OddOccurrencesInArray
    /// </summary>
    public class OddOccurrencesInArray
    {
        public int Find(int[] A)
        {
            //Xor operator(^) is useful to detect overlaping 
            return A.Aggregate((current, next) => current ^ next);
        }
    }
}

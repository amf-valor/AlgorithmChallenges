using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class UnpairedNumbersFinder
    {
        public int Find(int[] A)
        {
            //Xor operator(^) is useful to detect overlaping 
            return A.Aggregate((current, next) => current ^ next);
        }
    }
}

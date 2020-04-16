using System.Collections.Generic;

namespace CtCi.Solutions.ArraysAndStrings
{
    public class CheckPermutation
    {
        /// <summary>
        /// Remmember to ask for assumptions like strings are unicode, ASCII, is case sensitive
        /// </summary>
        /// <param name="one"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool IsPermutation(string one, string other) 
        {
            if (string.IsNullOrEmpty(one) || 
                string.IsNullOrEmpty(other) ||
                one.Length != other.Length) 
            {
                return false;
            }

            HashSet<char> charHashSet = new HashSet<char>(other.ToCharArray());

            foreach (char c in one) 
            {
                if (!charHashSet.Contains(c)) 
                {
                    return false ;
                }
            }

            return true;
        }
    }
}

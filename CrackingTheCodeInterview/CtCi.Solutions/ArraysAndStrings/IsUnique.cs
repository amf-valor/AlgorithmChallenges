using System;

namespace CtCi.Solutions.ArraysAndStrings
{
    public class IsUnique
    {
        public bool Evaluate(string any) 
        {
            if (string.IsNullOrEmpty(any)) 
            {
                return false;
            }

            int currentIndex = 0;
            int nextIndex = 1;
            char[] sortedAny = GetSortedChars(any);

            while (nextIndex < any.Length - 1) 
            {
                if (sortedAny[currentIndex] == sortedAny[nextIndex]) 
                {
                    return false;
                }

                currentIndex++;
                nextIndex++;
            }
            
            return true;
        }

        private char[] GetSortedChars(string any) 
        {
            char[] charsToSort = any.ToCharArray();
            Array.Sort(charsToSort);
            return charsToSort;
        }
    }
}

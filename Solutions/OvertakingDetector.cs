using System;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class OvertakingDetector
    {
        public int GetMinimum(int n, int[] start, int[] end)
        {
            int counter = 0;
            int overtaken = 0;
            int[] aux = new int[n];
            Array.Copy(start, aux, n);

            for (int i = 0; i < n; i++)
            {
                int diff = (Array.IndexOf(aux, end[i]) + overtaken) - i;

                if(diff > 0)
                {
                    counter += diff;
                    overtaken++;
                    aux = aux.Where(x => x!= end[i]).ToArray();
                }
            }

            return counter;
        }
    }
}

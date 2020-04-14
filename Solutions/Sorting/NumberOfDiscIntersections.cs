using System;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.Sorting
{
    /// <summary>
    /// Lesson 6 - NumberOfDisIntersections
    /// </summary>
    public class NumberOfDiscIntersections
    {
        /// <summary>
        /// 1. first step is to calculate all left points and right points based on radius and center of each circle
        /// 2. Now we must sort both arrays  
        /// 3. Loop through the left points counting the left points which is less or equals the right point which means
        /// we have opened disks which intersect between them.
        /// 4. If left pois greater than rigth point it means one of the disks closed and we need to subtract opened disks and 
        /// start to compare to the next right disk.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Detect(int[] A)
        {
            int intersections = 0;
            int openedDisks = 0;
            long[] leftPoints = new long[A.Length];
            long[] rightPoints = new long[A.Length];

            
            for (int i = 0; i < A.Length; i++)
            {
                leftPoints[i] = i - (long) A[i];
                rightPoints[i] = i + (long) A[i];
            }

            Array.Sort(leftPoints);
            Array.Sort(rightPoints);
            int j = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (leftPoints[i] <= rightPoints[j])
                {
                    intersections += openedDisks;
                    openedDisks++;
                }
                else
                {
                    i--;
                    j++;
                    openedDisks--;
                }

                if (intersections > 10000000) return -1;
            }

            return intersections;
        }
    }
}

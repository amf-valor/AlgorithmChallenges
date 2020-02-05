using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions
{
    public class FishesAliveCounter
    {
        public int Count(int[] A, int[] B)
        {
            Stack<int> fishesAlive = new Stack<int>();

            if (A.Length == 1)
                return 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (fishesAlive.Count() == 0)
                {
                    fishesAlive.Push(i);
                }
                else
                {
                    int lastFish = fishesAlive.Peek();

                    if ((B[lastFish] - B[i]) == 1)
                    {
                        if (A[lastFish] > A[i])
                        {
                            continue;
                        }
                        else
                        {
                            fishesAlive.Pop();
                            fishesAlive.Push(i);
                        }

                    }
                    else
                    {
                        fishesAlive.Push(i);
                    }
                }
            }

            return fishesAlive.Count;
        }
    }
}

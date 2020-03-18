using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.StacksQueues
{
    public class FishesAliveCounter
    {
        public int Count(int[] A, int[] B)
        {
            var upStreamFishesAlive = new Stack<int>();
            var downSteamFishesAlive = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0)
                {
                    upStreamFishesAlive.Push(A[i]);

                    while (downSteamFishesAlive.Count > 0)
                    {
                        if (downSteamFishesAlive.Peek() < A[i])
                        {
                            downSteamFishesAlive.Pop();
                        }
                        else
                        {
                            upStreamFishesAlive.Pop();
                            break;
                        }
                    }
                }
                else
                {
                    downSteamFishesAlive.Push(A[i]);
                }
            }

            return upStreamFishesAlive.Count + downSteamFishesAlive.Count;
        }

        public int solution(int[] A, int[] B)
        {
            int N = A.Length;

            Stack<int> upStream = new Stack<int>();
            Stack<int> downStream = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                if ((B[i] == 0))
                {
                    upStream.Push(A[i]);

                    while (downStream.Count > 0)
                    {
                        if (downStream.Peek() < A[i])
                        {
                            downStream.Pop();
                        }
                        else
                        {
                            upStream.Pop();
                            break;
                        }
                    }
                }
                else
                {
                    downStream.Push(A[i]);
                }
            }

            return downStream.Count + upStream.Count;
        }
    }
}

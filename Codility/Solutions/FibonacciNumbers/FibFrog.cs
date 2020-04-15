using System.Collections.Generic;
using System.Linq;

namespace AlgorithmChallenges.Codility.Solutions.FibonacciNumbers
{
    /// <summary>
    /// Lesson 13 - FibFrog
    /// </summary>
    public class FibFrog
    {
        /// <summary>
        /// Implementation of BFS(Breadth-First-Search) with Fibonacci distances
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Count(int[] A)
        {
            if (A.Length <= 2)
            {
                return 1;
            }

            List<int> fibonacciSequence = GetFibonacciSequence(A.Length + 1).Reverse().ToList();
            Queue<Position> reachables = new Queue<Position>();
            bool[] marks = new bool[A.Length];
            Position start = new Position(-1, 0);

            reachables.Enqueue(start);

            while (reachables.Count > 0)
            {
                Position position = reachables.Dequeue();
                bool marked = position.Index == -1 ? false : marks[position.Index];

                if (!marked)
                {
                    foreach (int fibonacciNumber in fibonacciSequence)
                    {
                        if (fibonacciNumber == A.Length + 1 || A.Length - position.Index == fibonacciNumber)
                        {
                            return position.Jumps + 1;
                        }

                        int nextReachablePosition = position.Index + fibonacciNumber;

                        if (nextReachablePosition < A.Length &&
                            !marks[nextReachablePosition] &&
                            A[nextReachablePosition] == 1)
                        {
                            reachables.Enqueue(new Position(nextReachablePosition, position.Jumps + 1));
                        }
                    }
                }
                else if (position.Index != -1)
                {
                    marks[position.Index] = true;
                }
            }

            return -1;
        }

        private IList<int> GetFibonacciSequence(int to)
        {
            var sequence = new List<int>{ 1, 2};
            int index = 2;
            int nextFibonacciNumber = sequence[index - 2] + sequence[index - 1];

            while (nextFibonacciNumber <= to)
            {
                sequence.Add(nextFibonacciNumber);
                index++;
                nextFibonacciNumber = sequence[index - 2] + sequence[index - 1];
            }

            return sequence;
        }

        private class Position
        {
            public int Jumps{ get; }
            public int Index { get; }
            public Position(int index, int jumps)
            {
                Index = index;
                Jumps = jumps;
            }
        }

    }
}






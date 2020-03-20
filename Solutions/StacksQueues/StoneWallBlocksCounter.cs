using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.Solutions.StacksQueues
{
    /// <summary>
    /// Lesson 7 - a. StoneWall
    /// </summary>
    public class StoneWallBlocksCounter
    {
        /// <summary>
        /// This one took me a while to understand what the problem was asking. Basically we can reuse some blocks depending on wall's size
        /// For example: h[]{3, 4, 3, 1, 3} should return 4 blocks that's because always when the wall' size increase we do need to increase 1 block,
        /// but if it decrease we should check before if there is any other block on the same size that we can reuse and there is no smaller blocks 
        /// in between. In this example {3,4,3} we can reuse block 3 so we need 2 blocks to build the wall. 
        /// In this case {3,1,3} we can't because number one is less than 3 not being a base block.
        ///   
        ///   0 1 2 3 4
        /// 4   |
        /// 3 |---|   |
        ///   |   |   |
        /// 1 |   |---|
        /// 
        /// this picture shows one possible solution and why we can reuse block 3 in the first case and, not in the second one. 
        /// </summary>
        /// <param name="H"></param>
        /// <returns></returns>
        public int Count(int[] H)
        {
            //start with one because I need At Least one block to build the wall.
            int blocks = 1;
            var baseBlocks = new Stack<int>();
            baseBlocks.Push(H[0]);

            for (int i = 1; i < H.Length; i++)
            {
                int baseBlock = 0;

                if (baseBlocks.Count > 0)
                    baseBlock = baseBlocks.Peek();

                if (H[i] > baseBlock)
                {
                    baseBlocks.Push(H[i]);
                    blocks++;
                }
                else if (H[i] < baseBlock)
                {
                    baseBlocks.Pop();
                    i--;
                }

            }

            return blocks;

        } 
    }
}

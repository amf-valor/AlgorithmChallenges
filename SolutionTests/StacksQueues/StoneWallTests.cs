using AlgorithmChallenges.Codility.Solutions.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.StacksQueues
{
    [TestClass]
    public class StoneWallTests
    {
        [TestMethod]
        [DataRow(new int[] { 1000000000 }, 1, DisplayName = "ShouldCount1Extreme")]
        [DataRow(new int[] { 1000000000, 1, 1000000000 }, 3, DisplayName = "ShouldCount3BlocksExtreme")]
        [DataRow(new int[] { 1, 1000000000 }, 2, DisplayName = "ShouldCount2BlocksExtreme")]
        [DataRow(new int[] { 3, 4, 3 , 1 , 3 }, 4, DisplayName = "ShouldCount4Blocks")]
        [DataRow(new int[] { 3, 4, 3 }, 2, DisplayName = "ShouldCount2Blocks")]
        [DataRow(new int[] { 8, 8, 5 ,7 ,9, 8, 7, 4, 8}, 7, DisplayName = "example test")]
        public void ShouldCountMinimumBlocks(int[] H, int expected)
        {
            StoneWall counter = new StoneWall();
            int actual = counter.Count(H);
            Assert.AreEqual(expected, actual);
        }
    }
}

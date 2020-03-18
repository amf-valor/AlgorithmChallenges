using AlgorithmChallenges.Codility.Solutions.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.StacksQueues
{
    [TestClass]
    public class FishesAliveCounterTests
    {   
        [TestMethod]
        [DataRow(new int[] { 4, 3, 2, 1, 5 }, new int[] { 1, 0, 0, 0, 0 }, 1, DisplayName = "FirstDown")]
        [DataRow(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 1, 1, 0 }, 2, DisplayName = "ThreeDown")]
        [DataRow(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }, 2, DisplayName = "SecondDown")]
        [DataRow(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 0, 0, 0, 1 }, 5, DisplayName = "LastDown")]
        [DataRow(new int[] { 4 }, new int[] { 0 }, 1)]
        [DataRow(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 0, 0, 0, 1 }, 5)]
        public void ShouldCountFishesAlive(int[] A, int[] B, int expected)
        {
            FishesAliveCounter counter = new FishesAliveCounter();
            int actual = counter.Count(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}

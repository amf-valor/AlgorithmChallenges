using AlgorithmChallenges.Codility.Solutions.GreedyAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.GreedyAlgorithms
{
    [TestClass]
    public class TieRopesTests
    {
        [TestMethod]
        [DataRow(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 3, DisplayName ="GetTiedExampleTestShouldReturn3")]
        [DataRow(1, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 7, DisplayName = "GetTiedK1ShouldReturnAllRopes")]
        [DataRow(2, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 5, DisplayName = "GetTiedK2ShouldReturn5")]
        [DataRow(10, new int[] { 1, 2, 3 }, 0, DisplayName = "GetTiedKGreaterThanRopesShouldReturn0")]
        [DataRow(2, new int[] { 1 }, 0, DisplayName = "GetTiedKGreaterThanSingleRopeShouldReturn0")]
        public void GetTiedShouldReturnTiedRopesGreaterThanK(int k, int[] a, int expected)
        {
            TieRopes tier = new TieRopes();
            int actual = tier.GetTied(k, a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 3, DisplayName = "SolutionExampleTestShouldReturn3")]
        [DataRow(1, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 7, DisplayName = "SolutionK1ShouldReturnAllRopes")]
        [DataRow(2, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 5, DisplayName = "SolutionK2ShouldReturn5")]
        [DataRow(10, new int[] { 1, 2, 3 }, 0, DisplayName = "SolutionKGreaterThanRopesShouldReturn0")]
        [DataRow(2, new int[] { 1 }, 0, DisplayName = "SolutionKGreaterThanSingleRopeShouldReturn0")]
        public void SolutionShouldReturnTiedRopesGreaterThanK(int k, int[] a, int expected)
        {
            TieRopes tier = new TieRopes();
            int actual = tier.solution(k, a);
            Assert.AreEqual(expected, actual);
        }
    }
}


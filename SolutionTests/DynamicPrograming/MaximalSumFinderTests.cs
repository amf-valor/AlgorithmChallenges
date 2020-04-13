using AlgorithmChallenges.Codility.Solutions.DynamicPrograming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.DynamicPrograming
{
    [TestClass]
    public class MaximalSumFinderTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, -2, 0, 9, -1, -2 }, 8)]
        public void FindShouldReturnMaximalSum(int[] a, int expected)
        {
            MaximalSumFinder finder = new MaximalSumFinder();
            int actual = finder.Find(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

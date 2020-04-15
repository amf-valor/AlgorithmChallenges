using AlgorithmChallenges.Codility.Solutions.Leader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Leader
{
    [TestClass]
    public class DominatorTests
    {
        [TestMethod]
        [DataRow(new int[] { -2147483648, -2147483648, 2147483647, 2147483647, -2147483648 }, 0, DisplayName = "ShouldReturnDominatorExtremeValues")]
        [DataRow(new int[] { -2147483648 }, 0, DisplayName = "ShouldReturnLowestSingleDominator")]
        [DataRow(new int[] { }, -1, DisplayName = "ShouldReturnLess1IfAEmpty")]
        [DataRow(new int[] { 1,2 }, -1, DisplayName = "ShouldReturnLess1IfNotFound")]
        [DataRow(new int[] { 3, 4, 3, 2, 3, -1, 3, 3}, 0, DisplayName ="example test")]
        public void ShouldFindIndexOfDominator(int[] A, int expected)
        {
            Dominator dominator = new Dominator();
            int actual = dominator.Find(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

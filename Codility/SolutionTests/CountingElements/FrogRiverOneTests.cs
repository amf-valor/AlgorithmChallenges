using AlgorithmChallenges.Codility.Solutions.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.CountingElements
{
    [TestClass]
    public class FrogRiverOneTests
    {

        [TestMethod]
        [DataRow(1, new int[] { 1 }, 0, DisplayName = "FindShoulReturn0WhenGivenXis1AndAHas1")]
        [DataRow(1, new int[] { 1 }, 0, DisplayName = "FindShoulReturn0WhenGivenXis1AndAHas1")]
        [DataRow(2, new int[] { 2, 2, 2, 2, 2, 2, 2, 2 }, -1, DisplayName = "FindShoulReturnLess1WhenGivenAHasAllSameValue")]
        [DataRow(10, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, -1, DisplayName = "FindShoulReturnLess1WhenGivenXHigherThanALength")]
        [DataRow(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6, DisplayName = "FindShoulReturn6WhenGivenX5AndAllLeavesAppeardAtPosition6")]
        public void FindShoulReturnEarliestTimeWhichFrogCanJumpWhenGivenNonEmptyArrayAndJumpSize(int x, int[] a, int expected)
        {
            FrogRiverOne finder = new FrogRiverOne();
            int actual = finder.Find(x, a);
            Assert.AreEqual(expected, actual);
        }
    }
}

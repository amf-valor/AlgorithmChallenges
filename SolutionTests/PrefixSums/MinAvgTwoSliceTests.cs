using AlgorithmChallenges.Codility.Solutions.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.PrefixSums
{
    [TestClass]
    public class MinAvgTwoSliceTests
    {
        [TestMethod]
        [DataRow(new int[] { 10, 25 }, 0, DisplayName = "FindShouldReturnZeroWhenGivenAHasOnlyTwoElements")]
        [DataRow(new int[] { 10, 25, -10000, -4000, 2, 60, 90 }, 2, DisplayName = "FindShouldReturnStartPositionOfMinAvgWhenGivenAHasNegativeAndPsitiveElements")]
        [DataRow(new int[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, 0, DisplayName = "FindShouldReturnZeroWhenGivenAHasOnlyMaxValues")]
        [DataRow(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1, DisplayName = "FindShouldReturnStartPositionOfMinAvgWhenGivenAHasOnlyPositiveElements")]
        public void FindShouldReturnStartPositionOfMinAvgWhenGivenNonEmptyA(int[] a, int expected)
        {
            MinAvgTwoSlice finder = new MinAvgTwoSlice();
            int actual = finder.Find(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

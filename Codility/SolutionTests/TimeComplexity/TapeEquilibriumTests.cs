using AlgorithmChallenges.Codility.Solutions.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.TimeComplexity
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        [DataRow(new int[] { -3, 3, 1, 2, 4, 3 }, 4, DisplayName = "MinimizeShouldReturn4WhenGivenArrayHas4asMinimumDiferenceAndNegativeNumbers")]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1, DisplayName = "MinimizeShouldReturn1WhenGivenArrayHas1asMinimumDiference")]
        [DataRow(new int[] { 3, 6 }, 3, DisplayName = "MinimizeShouldReturn3WhenGivenArrayHas3asMinimumDiference")]
        public void MinimizeShouldReturnMinimalDiferenceWhenGivenNonEmptyArray(int[] a, int expected)
        {
            TapeEquilibrium minimizer = new TapeEquilibrium();
            int actual = minimizer.Minimize(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

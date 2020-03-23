using AlgorithmChallenges.Codility.Solutions.MaximumSliceProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.MaximumSliceProblem
{
    [TestClass]
    public class MaxProfitCalculatorTests
    {
        [TestMethod]
        [DataRow(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356, DisplayName = "example test")]
        [DataRow(new int[] { 10, 0, 12, 18, 2, 0 }, 18, DisplayName = "ShouldCalculate18WithZeros")]
        [DataRow(new int[] { 6, 1, 2, 4, 1, 8, 1, 2}, 7, DisplayName = "ShouldCalculate7AfterDrawDowns")]
        [DataRow(new int[] { 10, 0, 12, 18, 2, 0 }, 18, DisplayName = "ShouldCalculate18WithZeros")]
        [DataRow(new int[] { 5, 3, 1 }, 0, DisplayName = "ShouldCalculate0ForImpossibleProfit")]
        [DataRow(new int[] { 1, 199999, 200000 }, 199999, DisplayName = "ShouldCalculate199999Extremes")]
        [DataRow(new int[] { }, 0, DisplayName = "ShouldCalculate0Empty")]
        [DataRow(new int[] { 23171 }, 0, DisplayName = "ShouldCalculate0SinglePrice")]
        [DataRow(new int[] { 8, 9, 3, 6, 1, 2 }, 3, DisplayName = "ShouldCalculate3RandomRange")]
        public void ShoulCalculateMaxProfit(int[] A, int expected)
        {
            MaxProfitCalculator calculator = new MaxProfitCalculator();
            int actual = calculator.Calculate(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

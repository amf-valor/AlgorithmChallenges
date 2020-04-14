using AlgorithmChallenges.Codility.Solutions.FibonacciNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.FibonacciNumbers
{
    [TestClass]
    public class MinimumJumpsCounterTests
    {
        [TestMethod]
        [DataRow(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 }, 3, DisplayName = "CountRandomLeavesShouldReturn3")]
        [DataRow(new int[] { }, 1, DisplayName = "CountWithEmptyLeavesShoulReturnLess1")]
        [DataRow(new int[] { 0 }, 1, DisplayName = "CountWithOneLeafShoulReturn1")]
        [DataRow(new int[] { 0, 0, 0, 0, 0 }, -1, DisplayName = "CountWithNoLeavesAndHasFibonacciLengthShouldReturnLess1")]
        [DataRow(new int[] { 0, 0, 0, 0 }, 1, DisplayName = "CountWithNoLeavesAndHasFibonacciLess1LengthShouldReturn1")]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, 2, DisplayName = "CountWithAllLeavesShouldReturn2")]
        [DataRow(new int[] { 0, 0, 0, 0, 1 }, 2, DisplayName = "CountWithOnlyTheLastLeafShouldReturn2")]
        [DataRow(new int[] { 1, 1, 0, 0, 0 }, 2, DisplayName = "CountWithCiclicLeavesShouldReturn2")]
        [DataRow(new int[] { 0, 1, 0, 1, 0 }, 3, DisplayName = "CountWith2LeavesIntercalatedShouldReturnLess3")]
        [DataRow(new int[] { 0, 1, 0, 0, 0 }, -1, DisplayName = "CountWith1PossibleLeafAndNoPossibleJumpsAnymoreShouldReturnLess1")]
        [DataRow(new int[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, -1, DisplayName = "CountWithCiclicLeavesShouldReturn2")]
        public void CountNotNullArrayShouldReturnMinimumJumps(int[] a, int expected)
        {
            var counter = new MinimumJumpsCounter();
            var actual = counter.Count(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

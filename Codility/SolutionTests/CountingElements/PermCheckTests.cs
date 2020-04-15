using AlgorithmChallenges.Codility.Solutions.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.CountingElements
{
    [TestClass]
    public class PermCheckTests
    {
        [TestMethod]
        [DataRow(new int[] { 3 }, 0, DisplayName = "CheckShouldReturn0WhenGivenAHasOnlyOneValueAndTheValueIsNotOne")]
        [DataRow(new int[] { 1 }, 1, DisplayName = "CheckShouldReturn1WhenGivenAHasOnlyOneValueAndTheValueIsOne")]
        [DataRow(new int[] { 4, 1, 3 }, 0, DisplayName = "CheckShouldReturn0WhenGivenAHasAnyMissingValue")]
        [DataRow(new int[] { 4, 1, 3, 2 }, 1, DisplayName = "CheckShouldReturn1WhenGivenAHasAllNumbers")]
        public void CheckShouldReturn1ForPermutationOr0IfItsNotWhenGivenA(int[] a, int expected)
        {
            PermCheck checker = new PermCheck();
            int actual = checker.Check(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

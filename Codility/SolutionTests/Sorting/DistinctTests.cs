using AlgorithmChallenges.Codility.Solutions.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Sorting
{
    [TestClass]
    public class DistinctTests
    {
        [TestMethod]
        [DataRow(new int[] { }, 0, DisplayName = "GetShoulReturnZeroWhenAIsEmpty")]
        [DataRow(new int[] { -1, -1, -1000000, 1000000 }, 3, DisplayName = "GetShoulReturnNumberOfDistinctNumbersWhenGivenAHasPositiveAndNegatives")]
        [DataRow(new int[] { 2, 1, 1, 2, 3, 1 }, 3, DisplayName = "GetShoulReturnNumberOfDistinctNumbersWhenGivenAAreAllPositives")]
        public void GetShoulReturnNumberOfDistinctNumbersWhenGivenA(int[] a, int expected)
        {
            Distinct getter = new Distinct();
            int actual = getter.Get(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

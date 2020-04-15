using AlgorithmChallenges.Codility.Solutions.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.CountingElements
{
    [TestClass]
    public class MaxCountersTests
    {
        [TestMethod]
        [DataRow(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 }, DisplayName = "CountShoulReturnCountersWhenGivenNonEmptyAAndNis5")]
        public void CountShoulReturnCountersWhenGivenNonEmptyAWithIncreseAndMaxOperationsAndN(int n, int[] a, int[] expected)
        {
            MaxCounters counter = new MaxCounters();
            int[] actual = counter.Count(n, a);
            CollectionAssert.AreEqual(actual, expected);

        }
    }
}

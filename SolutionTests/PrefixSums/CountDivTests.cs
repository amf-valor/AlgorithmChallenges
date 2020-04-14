using AlgorithmChallenges.Codility.Solutions.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.PrefixSums
{
    [TestClass]
    public class CountDivTests
    {
        [TestMethod]
        [DataRow(101, 123456789, 10000, 12345, DisplayName = "CountShouldReturnNumberOfDivisibleNumbersWhenAandBAndKRepeatDecimals")]
        [DataRow(1, 1, 1, 1, DisplayName = "CountShouldReturnOneWhenAandBandKAreAllTheSame")]
        [DataRow(11, 13, 2, 1, DisplayName = "CountShouldReturnNumberOfDivisibleNumbersWhenAandBIsPrime")]
        [DataRow(0, 15, 2, 8, DisplayName = "CountShouldReturnNumberOfDivisibleNumbersWhenAandBReachBoundaires")]
        [DataRow(0, 13, 2, 7, DisplayName = "CountShouldReturnNumberOfDivisibleNumbersWhenGivenAisZeroBIsPrime")]
        [DataRow(0, 14, 2, 8, DisplayName = "CountShouldNumberOfDivisibleNumbersPlusAWhenGivenAis0")]
        [DataRow(0, 0, 3, 1, DisplayName = "CountShouldReturnOneWhenGivenAandBasZero")]
        [DataRow(4,4, 3, 0, DisplayName = "CountShouldReturnZeroWhenNoNumbersFromAToBIsDivisibleByK")]
        [DataRow(6, 11, 2, 3, DisplayName = "CountShouldReturnNumberOfDivisibleNumbersWhenGivenAisDivisibleByKAndHasMoreToB")]
        public void CountShouldReturnNumberOfDivisibleNumbersWhenGivenAandB(int a, int b, int k, int expected)
        {
            CountDiv counter = new CountDiv();
            int actual = counter.Count(a, b, k);
            Assert.AreEqual(expected, actual);
        }
    }
}

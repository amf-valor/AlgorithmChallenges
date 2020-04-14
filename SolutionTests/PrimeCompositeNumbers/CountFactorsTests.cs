using AlgorithmChallenges.Codility.Solutions.PrimeCompositeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.PrimeCompositeNumbers
{
    [TestClass]
    public class CountFactorsTests
    {
        [TestMethod]
        [DataRow(24, 8, DisplayName = "example test")]
        [DataRow(7, 2, DisplayName = "ShouldCount2ForPrimes")]
        [DataRow(1, 1, DisplayName = "ShouldCount1For1Prime")]
        [DataRow(41, 2, DisplayName = "ShouldCount2ForPrime41")]
        [DataRow(16, 5, DisplayName = "ShouldCount5ForCompositeSquareEqualsN")]
        public void ShouldCountFactorsOfN(int N, int expected)
        {
            CountFactors counter = new CountFactors();
            int actual = counter.Count(N);
            Assert.AreEqual(expected, actual);
        }
    }
}

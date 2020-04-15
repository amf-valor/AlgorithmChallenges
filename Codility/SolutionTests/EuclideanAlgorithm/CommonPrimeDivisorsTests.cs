using AlgorithmChallenges.Codility.Solutions.EuclideanAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.EuclideanAlgorithm
{
    [TestClass]
    public class CommonPrimeDivisorsTests
    {
        [TestMethod]
        [DataRow(new int[] { 17, 7}, new int[] { 23, 13}, 0, DisplayName ="OnlyPrimes")]
        [DataRow(new int[] { 15, 10, 3 }, new int[] { 75, 30, 5 }, 1, DisplayName ="ExampleTests")]
        public void ShouldCount_TwoNonEmptyArrays_ReturnsCounterOfCommonPrimesDivisor(int[]A, int[]B, int expected)
        {
            var counter = new CommonPrimeDivisors();
            var actual = counter.Count(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}

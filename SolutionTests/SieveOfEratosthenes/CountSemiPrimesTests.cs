using AlgorithmChallenges.Codility.Solutions.SieveOfEratosthenes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmChallenges.Codility.SolutionTests.SieveOfEratosthenes
{
    [TestClass]
    public class CountSemiPrimesTests
    {
        [DataTestMethod]
        [DataRow(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 }, new int[] { 10, 4, 0 }, DisplayName ="ExampleTest")]
        [DataRow(1, new int[] { 1 }, new int[] { 1 }, new int[] { 0 }, DisplayName = "ShoulCountSemiPrimesAs0ForElement1")]
        [DataRow(26, new int[] { 1, 2, 1 }, new int[] { 2, 2, 3 }, new int[] { 0, 0, 0 }, DisplayName = "ShoulCountSemiPrimesAs0WhenNotFound")]
        public void ShoulCountSemiPrimes(int n, int[] p,  int[]q, int[] expected)
        {
            var semiPrimeCounter = new CountSemiprimes();
            int[] actual = semiPrimeCounter.Count(n, p, q);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

    }
}

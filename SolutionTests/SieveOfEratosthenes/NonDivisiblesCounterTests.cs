using AlgorithmChallenges.Codility.Solutions.SieveOfEratosthenes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmChallenges.Codility.SolutionTests.SieveOfEratosthenes
{
    [TestClass]
    public class NonDivisiblesCounterTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 3, 1, 2, 3, 6 }, new int[] { 2, 4, 3, 2, 0 }, DisplayName = "ExampleTest")]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 0, 0, 0, 0, 0 }, DisplayName = "ShoulCountNonDivisiblesAsAll0WhenIsAll1")]
        [DataRow(new int[] { 7 }, new int[] { 0 }, DisplayName = "ShoulCountNonDivisibles0For1PrimeElement")]
        [DataRow(new int[] { 3, 1, 2, 3, 6, 8 }, new int[] { 3, 5, 4, 3, 1, 3 }, DisplayName = "ShoulCountNonDivisibleRandomNumbers")]
        [DataRow(new int[] { 2, 4 }, new int[] { 1, 0 }, DisplayName = "ShoulCountNonDivisiblesDoubleElements")]
        [DataRow(new int[] { 3, 1, 7, 5, 13 }, new int[] { 3, 4, 3, 3, 3 }, DisplayName = "ShoulCountNonDivisiblesOnlyPrimes")]
        [DataRow(new int[] { 3, 4 }, new int[] { 1, 1 }, DisplayName = "ShoulCountNonDivisiblesPrimeAndComposite")]
        public void ShouldCountNonDivisibles(int[] A, int[] expected)
        {
            NonDivisiblesCounter counter = new NonDivisiblesCounter();
            var actual = counter.Count(A);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}

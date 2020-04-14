using AlgorithmChallenges.Codility.Solutions.EuclideanAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.EuclideanAlgorithm
{
    [TestClass]
    public class ChocolatesByNumbersTests
    {
        [TestMethod]
        [DataRow(10, 4, 5, DisplayName ="ExampleTest")]
        public void ShoulCountChocolatesEaten(int n, int m, int expected)
        {
            var counter = new ChocolatesByNumbers();
            int actual = counter.Count(n, m);
            Assert.AreEqual(expected, actual);
        }
    }
}

using AlgorithmChallenges.Codility.Solutions.BinarySearchAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.BinarySearchAlgorithm
{
    [TestClass]
    public class LargeSumMinimizorTests
    {
        [TestMethod]
        [DataRow(3 , 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        public void MinimizeNonEmptyArrayShouldReturnMinLargeSum(int K, int M, int[] A, int expected) 
        {
            LargeSumMinimizor minimizor = new LargeSumMinimizor();
            int actual = minimizor.Minimize(K, M, A);
            Assert.AreEqual(expected, actual);
        }
    }
}

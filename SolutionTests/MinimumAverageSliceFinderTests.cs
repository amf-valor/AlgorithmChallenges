using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class MinimumAverageSliceFinderTests
    {
        [TestMethod]
        public void ShouldReturn1()
        {
            MinimumAverageSliceFinder finder = new MinimumAverageSliceFinder();
            int[] A = new int[] { 4, 2, 2, 5, 1, 5, 8 };
            int expected = 1;
            int actual = finder.Find(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0AllSameMaxInteger()
        {
            MinimumAverageSliceFinder finder = new MinimumAverageSliceFinder();
            int[] A = new int[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000 };
            int expected = 0;
            int actual = finder.Find(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn2WithNegativeNumbers()
        {
            MinimumAverageSliceFinder finder = new MinimumAverageSliceFinder();
            int[] A = new int[] { 10, 25, -10000, -4000, 2, 60, 90};
            int expected = 2;
            int actual = finder.Find(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0WithTwoNumbers()
        {
            MinimumAverageSliceFinder finder = new MinimumAverageSliceFinder();
            int[] A = new int[] { 10, 25 };
            int expected = 0;
            int actual = finder.Find(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

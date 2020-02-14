using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class PermElemFinderTests
    {
        [TestMethod]
        public void ShouldReturn4()
        {
            int[] a = new int[] { 2, 3, 1, 5 };

            PermElemFinder finder = new PermElemFinder();

            int actual = finder.Find(a);
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn2()
        {
            int[] a = new int[] { 4, 3, 1, 5 };

            PermElemFinder finder = new PermElemFinder();

            int actual = finder.Find(a);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}

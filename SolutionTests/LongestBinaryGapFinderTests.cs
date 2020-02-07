using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class LongestBinaryGapFinderTests
    {
        [TestMethod]
        public void ShouldGetGap2()
        {
            LongestBinaryGapFinder finder = new LongestBinaryGapFinder();

            int expected = 2;
            int actual = finder.Find(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetGap4()
        {
            LongestBinaryGapFinder finder = new LongestBinaryGapFinder();

            int expected = 4;
            int actual = finder.Find(529);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetGap0When15()
        {
            LongestBinaryGapFinder finder = new LongestBinaryGapFinder();

            int expected = 0;
            int actual = finder.Find(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetGap0When32()
        {
            LongestBinaryGapFinder finder = new LongestBinaryGapFinder();

            int expected = 0;
            int actual = finder.Find(32);

            Assert.AreEqual(expected, actual);
        }

    }
}

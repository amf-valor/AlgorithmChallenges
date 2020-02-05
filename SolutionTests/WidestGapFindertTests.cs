using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUtilityTests
{
    [TestClass]
    public class WidestGapFinderTests
    {
        [TestMethod]
        public void ShouldReturn3()
        {
            WidestGapFinder finder = new WidestGapFinder();
            int[] X = new int[] { 1, 8, 7, 3, 4, 1, 8 };
            int[] Y = new int[] { 6,4,1,8,5,1,7};

            int expected = 3;
            int actual = finder.Find(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn2()
        {
            WidestGapFinder finder = new WidestGapFinder();
            int[] X = new int[] { 5,5,5,7,7,7 };
            int[] Y = new int[] { 3,4,5,1,3,7};

            int expected = 2;
            int actual = finder.Find(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn4()
        {
            WidestGapFinder finder = new WidestGapFinder();
            int[] X = new int[] { 6,10,1,4,3};
            int[] Y = new int[] { 2,5,3,1,6 };

            int expected = 4;
            int actual = finder.Find(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn10()
        {
            WidestGapFinder finder = new WidestGapFinder();
            int[] X = new int[] { 1, 11};
            int[] Y = new int[] { 1, 11};

            int expected = 10;
            int actual = finder.Find(X, Y);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ShouldReturn1()
        {
            WidestGapFinder finder = new WidestGapFinder();
            int[] X = new int[] { 1, 1 };
            int[] Y = new int[] { 1, 11 };

            int expected = 1;
            int actual = finder.Find(X, Y);

            Assert.AreEqual(expected, actual);
        }
    }
}

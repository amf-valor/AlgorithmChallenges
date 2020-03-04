using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class EarliestFrogJumperFinderTests
    {

        [TestMethod]
        public void ShouldReturn6()
        {
            EarliestFrogJumperFinder finder = new EarliestFrogJumperFinder();
            int actual = finder.Find(5, new int[] {1,3,1,4,2,3,5,4 });
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnLess1WhenNotFound()
        {
            EarliestFrogJumperFinder finder = new EarliestFrogJumperFinder();
            int actual = finder.Find(10, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnLess1WhenAllSameValue()
        {
            EarliestFrogJumperFinder finder = new EarliestFrogJumperFinder();
            int actual = finder.Find(2, new int[] { 2, 2, 2, 2, 2, 2, 2, 2 });
            int expected = -1;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ShouldReturn1()
        {
            EarliestFrogJumperFinder finder = new EarliestFrogJumperFinder();
            int actual = finder.Find(1, new int[] { 1 });
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn3()
        {
            EarliestFrogJumperFinder finder = new EarliestFrogJumperFinder();
            int actual = finder.Find(3, new int[] { 1, 3, 1, 3, 2, 1, 3 });
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }
}

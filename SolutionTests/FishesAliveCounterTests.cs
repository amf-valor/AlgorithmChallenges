using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUtilityTests
{
    [TestClass]
    public class FishesAliveCounterTests
    {
        [TestMethod]
        public void Should2FishesAlive()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 1, 0, 0, 0 };
            FishesAliveCounter counter = new FishesAliveCounter();
            int expected = 2;

            int actual = counter.Count(A, B);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Should1FishesAliveSingleFish()
        {
            int[] A = new int[] { 4 };
            int[] B = new int[] { 0 };
           FishesAliveCounter counter = new FishesAliveCounter();
            int expected = 1;

            int actual = counter.Count(A, B);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Should1FishAliveOnTop()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 1, 0, 0, 0, 0 };
           FishesAliveCounter counter = new FishesAliveCounter();
            int expected = 1;

            int actual = counter.Count(A, B);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShouldAllFishesBeAlive()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 0, 0, 0, 1 };
           FishesAliveCounter counter = new FishesAliveCounter();
            int expected = 5;

            int actual = counter.Count(A, B);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Should4FishesBeAlive()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 1, 1, 1, 0 };
           FishesAliveCounter counter = new FishesAliveCounter();
            int expected = 4;

            int actual = counter.Count(A, B);

            Assert.AreEqual(expected, actual);

        }
    }
}

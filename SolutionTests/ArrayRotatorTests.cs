using System.Linq;
using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class ArrayRotatorTests
    {
        [TestMethod]
        public void ShouldReturnSameGivenArray()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] { 1, 2, 3, 4 };
            int[] actual = rotator.Rotate(new int[] { 1, 2, 3, 4 }, 4);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        [TestMethod]
        public void ShouldRotateK1()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] { 4, 1, 2, 3 };
            int[] actual = rotator.Rotate(new int[] { 1, 2, 3, 4 }, 1);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        [TestMethod]
        public void ShouldRotateK2()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] { 3, 4, 1, 2 };
            int[] actual = rotator.Rotate(new int[] { 1, 2, 3, 4 }, 2);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        [TestMethod]
        public void ShouldRotateK5()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] {2, 3, 4, 11, 9, 1};
            int[] actual = rotator.Rotate(new int[] { 1, 2, 3, 4, 11, 9 }, 5);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        [TestMethod]
        public void ShouldRotateK3WithBondaries()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] {4, 1000, 9, -1000, 2, 3 };
            int[] actual = rotator.Rotate(new int[] { -1000, 2, 3, 4, 1000, 9 }, 3);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        [TestMethod]
        public void ShouldNotRotateK0()
        {
            ArrayRotator rotator = new ArrayRotator();
            int[] expected = new int[] { 4, 1000, 9, -1000, 2, 3 };
            int[] actual = rotator.Rotate(new int[] { 4, 1000, 9, -1000, 2, 3 }, 0);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }
    }
}

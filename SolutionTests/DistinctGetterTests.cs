using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class DistinctGetterTests
    {
        [TestMethod]
        public void ShouldGet3DistinctNumbers()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { 2,1,1,2,3,1 };
            int expected = 3;
            int actual = getter.Get(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGet3DistinctNumbersWithNegatives()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { -1, -1, -1000000, 1000000 };
            int expected = 3;
            int actual = getter.Get(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGet0DistinctNumbersEmptyArray()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { };
            int expected = 0;
            int actual = getter.Get(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetWithLambda3DistinctNumbers()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { 2, 1, 1, 2, 3, 1 };
            int expected = 3;
            int actual = getter.GetWithLambda(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetWithLambda3DistinctNumbersWithNegatives()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { -1, -1, -1000000, 1000000 };
            int expected = 3;
            int actual = getter.GetWithLambda(A);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetWithLambda0DistinctNumbersEmptyArray()
        {
            DistinctGetter getter = new DistinctGetter();
            int[] A = new int[] { };
            int expected = 0;
            int actual = getter.GetWithLambda(A);
            Assert.AreEqual(expected, actual);
        }

    }
}

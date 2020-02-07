using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class UnpairedNumbersFinderTests
    {
        [TestMethod]
        public void ShouldReturn7()
        {
            UnpairedNumbersFinder finder = new UnpairedNumbersFinder();
            int[] A = new int[] { 9,3,9,3,9,7,9 };

            int expected = 7;
            int actual = finder.Find(A);

            Assert.AreEqual(expected, actual);
        }
    }
}

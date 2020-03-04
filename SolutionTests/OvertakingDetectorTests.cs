using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class OvertakingDetectorTests
    {
        [TestMethod]
        public void ShouldReturn3()
        {
            OvertakingDetector detector = new OvertakingDetector();
            int actual = detector.GetMinimum(5, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 1, 2, 5, 4 });
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn3WhenReversed()
        {
            OvertakingDetector detector = new OvertakingDetector();
            int actual = detector.GetMinimum(5, new int[] { 3, 1, 2, 5, 4 }, new int[] { 1, 2, 3, 4, 5 });
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn4()
        {
            OvertakingDetector detector = new OvertakingDetector();
            int actual = detector.GetMinimum(5, new int[] { 3, 1, 2, 5, 4}, new int[] { 5, 3, 2, 1, 4});
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1()
        {
            OvertakingDetector detector = new OvertakingDetector();
            int actual = detector.GetMinimum(2, new int[] { 2, 1}, new int[] { 1, 2 });
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn7()
        {
            OvertakingDetector detector = new OvertakingDetector();
            int actual = detector.GetMinimum(6, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 2, 1, 4, 3, 5 });
            int expected = 7;

            Assert.AreEqual(expected, actual);
        }

    }
}

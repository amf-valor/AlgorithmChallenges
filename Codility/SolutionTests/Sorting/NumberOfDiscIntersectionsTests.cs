using AlgorithmChallenges.Codility.Solutions.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Sorting
{
    [TestClass]
    public class NumberOfDiscIntersectionsTests
    {
        [DataRow(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        [DataRow(new int[] { 1, 2147483647, 0 }, 2)]
        [DataTestMethod]
        public void ShouldDetectIntersections(int[] A, int expected)
        {
            NumberOfDiscIntersections detector = new NumberOfDiscIntersections();
            int actual = detector.Detect(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

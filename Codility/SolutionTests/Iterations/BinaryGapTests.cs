using AlgorithmChallenges.Codility.Solutions.Iterations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Iterations
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        [DataRow(15, 0, DisplayName = "FindShouldReturn0WhenGiven15")]
        [DataRow(529, 4, DisplayName = "FindShouldReturn4WhenGiven529")]
        [DataRow(9, 2,  DisplayName = "FindShouldReturn2WhenGiven9")]
        public void FindShouldReturnLogestSequenceOfZerosInBinaryRepresentation(int n, int expected)
        {
            BinaryGap finder = new BinaryGap();
            int actual = finder.Find(n);
            Assert.AreEqual(expected, actual);
        }
    }
}

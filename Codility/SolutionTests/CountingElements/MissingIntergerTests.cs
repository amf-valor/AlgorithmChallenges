using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmChallenges.Codility.Solutions.CountingElements;

namespace AlgorithmChallenges.Codility.SolutionTests.CountingElements
{
    [TestClass]
    public class MissingIntergerTests
    {
        [TestMethod]
        [DataRow(new int[] { -1000000, 5, 8, 1000000, -2, 1, 2 }, 3, DisplayName = "DetectShouldReturnSmallestPositiveValueWhenGivenASequenceHasExtremeValues")]
        [DataRow(new int[] { }, 1, DisplayName = "DetectShouldReturn1WhenGivenAisEmpty")]
        [DataRow(null, 1, DisplayName = "DetectShouldReturn1WhenGivenAisNull")]
        [DataRow(new int[] { -7, -5, -1, 3 }, 1, DisplayName = "DetectShouldReturnSmallestPositiveValueWhenGivenASequenceHasPositiveAndNegativeElements")]
        [DataRow(new int[] { -1 }, 1, DisplayName = "DetectShouldReturnNextValueWhenGivenAWithOnlyOneElement")]
        [DataRow(new int[] { -3, -1 }, 1, DisplayName = "DetectShouldReturnNextValueWhenGivenASequenceThatisFullfieldWithNegativeNumbers")]
        [DataRow(new int[] { 1, 2, 3 }, 4, DisplayName = "DetectShouldReturnNextValueWhenGivenASequenceThatisFullfield")]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5, DisplayName = "DetectShouldReturnSmallestPositiveValueWhenGivenASequenceThatIsMissingThisValue")]
        public void DetectShouldReturnTheSmallestPositiveIntergerWhenGivenASequence(int[] a, int expected)
        {
            MissingInterger detector = new MissingInterger();
            int actual = detector.Detect(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

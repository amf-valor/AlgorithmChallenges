using System.Linq;
using AlgorithmChallenges.Codility.Solutions.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Arrays
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        [DataRow(new int[] { 4, 1000, 9, -1000, 2, 3 }, 0, new int[] { 4, 1000, 9, -1000, 2, 3 }, DisplayName = "RotateShoulReturnArrayNotRotatedWhenKis0")]
        [DataRow(new int[] { -1000, 2, 3, 4, 1000, 9 }, 3, new int[] { 4, 1000, 9, -1000, 2, 3 }, DisplayName = "RotateShoulReturnArrayRotated3PositionsWhenGivenK3AndAWithExtremeValues")]
        [DataRow(new int[] { 1, 2, 3, 4, 11, 9 }, 5, new int[] { 2, 3, 4, 11, 9, 1 }, DisplayName = "RotateShoulReturnArrayRotated5PositionsWhenGivenK5")]
        [DataRow(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 }, DisplayName = "RotateShoulReturnArrayRotated2PositionsWhenGivenK2")]
        [DataRow(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 }, DisplayName = "RotateShoulReturnArrayRotated1PositionWhenGivenK1")]
        [DataRow(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 }, DisplayName ="RotateShoulReturnSameArrayWhenGivenKHasSameLengthOfA")]
        public void ShouldRotateReturnNewRotatedArrayWhenGivenNonEmptyAandK (int[] a, int k, int[] expected)
        {
            CyclicRotation rotator = new CyclicRotation();
            int[] actual = rotator.Rotate(a, k);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }
    }
}

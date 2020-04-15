using AlgorithmChallenges.Codility.Solutions.PrimeCompositeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.PrimeCompositeNumbers
{
    [TestClass]
    public class PeaksTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3, DisplayName = "ExampleTest")]
        [DataRow(new int[] { 1, 2, 3, 4 }, 0, DisplayName = "ShouldCount0BlocksWhenNoPeakIsFound")]
        [DataRow(new int[] { 1 }, 0, DisplayName = "ShouldCount0BlocksForArrayOf1Element")]
        [DataRow(new int[] { 1, 2 }, 0, DisplayName = "ShouldCount0BlocksForArrayOf2Element")]
        [DataRow(new int[] { 1, 2, 1, 4, 5, 6, 7, 8, 9, 10, 9, 12 }, 2, DisplayName = "ShouldCount2BlocksFor2Peaks")]
        [DataRow(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, 4, DisplayName = "ShouldCount4BlocksForMaximumPossiblePeaks")]
        [DataRow(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 3, 4, 5, 6 }, 1, DisplayName = "ShouldCount1BlockFor3PeaksOnlyInTheBegining")]
        [DataRow(new int[] { 1, 2, 1, 2, 1 }, 1, DisplayName = "ShouldCount1BlockForPrimeElements")]
        public void ShouldCountBlocksOfA(int[] A, int expected)
        {
            Peaks counter = new Peaks();
            int actual = counter.Count(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

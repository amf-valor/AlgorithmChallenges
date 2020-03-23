using AlgorithmChallenges.Codility.Solutions.Leader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Leader
{
    [TestClass]
    public class EquiLeaderCounterTests
    {
        [TestMethod]
        [DataRow(new int[] { 4, 3, 4, 4, 4, 2 }, 2, DisplayName = "example test")]
        [DataRow(new int[] { 4, 3, 4, 4, 4, 2, 4, 3, 2 ,2, 4 }, 0, DisplayName = "ShouldCount0EquiLeaders")]
        [DataRow(new int[] { 3, 3, 3 }, 2, DisplayName = "ShoulCount2SmallValues")]
        [DataRow(new int[] { 2 }, 0, DisplayName = "ShoulCount0ForSingleElement")]
        [DataRow(new int[] { 1000000000, -1000000000, 1000000000, 1000000000, 1000000000, -1000000000 }, 2, DisplayName = "ShoulCount2ForExtremeElements")]
        [DataRow(new int[] { 2, 3, 3, 4, 4 }, 0, DisplayName = "ShouldCount0WhenLeaderDoesNotExist")]
        public void ShouldCountEquiLeaders(int[] A, int expected)
        {
            EquiLeaderCounter counter = new EquiLeaderCounter();
            int actual = counter.Count(A);
            Assert.AreEqual(expected, actual);
        }
    }
}

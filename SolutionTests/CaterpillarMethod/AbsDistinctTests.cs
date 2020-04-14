using AlgorithmChallenges.Codility.Solutions.CaterpillarMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.CaterpillarMethod
{
    [TestClass]
    public class AbsDistinctTests
    {
        [TestMethod]
        [DataRow(new int[] { -5, 3, -1, 0, 3, 6 }, 5, DisplayName = "CountValuesShouldReturn5")]
        [DataRow(new int[] { -9, -3, -3, 2, 3, 3, 3 }, 3, DisplayName = "CountValuesShouldReturn3")]
        [DataRow(new int[] { -3, -3, 3, 3, 3 }, 1, DisplayName = "CountAllSameAbsValuesShouldReturn1")]
        [DataRow(new int[] { -3, -3, -2, -2, 2, 3, 3, 3 }, 2, DisplayName = "Count2DeacreasingAbsValuesShouldReturn2")]
        [DataRow(new int[] { -3 }, 1, DisplayName = "CountSingleValueShouldReturn1")]
        [DataRow(new int[] { int.MinValue, int.MinValue, int.MaxValue, int.MaxValue }, 2, DisplayName = "CountExtremeValuesShouldReturn2")]
        [DataRow(new int[] { int.MinValue, int.MinValue, int.MinValue }, 1, DisplayName = "CountAllMinValuesShouldReturn1")]
        [DataRow(new int[] { int.MinValue, -1, 0, 1}, 3, DisplayName = "CountMinAndRandomValuesShouldReturn3")]
        public void CountValuesShouldReturnDistinctAbsoluteOnes(int[] a, int expected)
        {
            AbsDistinct counter = new AbsDistinct();
            int actual = counter.Count(a);
            Assert.AreEqual(expected, actual);
        }

    }
}

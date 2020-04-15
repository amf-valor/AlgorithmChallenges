using AlgorithmChallenges.Codility.Solutions.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.Arrays
{
    [TestClass]
    public class OddOccurrencesInArrayTests
    {
        [TestMethod]
        public void ShouldReturnUnpairedValueWhenGivenNonEmptyA()
        {
            OddOccurrencesInArray finder = new OddOccurrencesInArray();
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            int expected = 7;
            int actual = finder.Find(A);

            Assert.AreEqual(expected, actual);
        }
    }
}

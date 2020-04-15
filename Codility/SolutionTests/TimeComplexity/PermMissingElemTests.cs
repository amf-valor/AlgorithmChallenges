using AlgorithmChallenges.Codility.Solutions.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.TimeComplexity
{
    [TestClass]
    public class PermMissingElemTests
    {
        [TestMethod]
        [DataRow(new int[] { 4, 3, 1, 5 }, 2, DisplayName = "FindShouldReturn2WhenGivenAisMissing2")]
        [DataRow(new int[] { 2, 3, 1, 5 }, 4, DisplayName ="FindShouldReturn4WhenGivenAisMissing4")]
        public void FindShouldReturnMissingElementWhenGivenNonEmptyArray(int[] a, int expected)
        {
            PermMissingElem finder = new PermMissingElem();
            int actual = finder.Find(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

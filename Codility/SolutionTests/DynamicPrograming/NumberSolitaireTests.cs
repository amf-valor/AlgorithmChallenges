using AlgorithmChallenges.Codility.Solutions.DynamicPrograming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.DynamicPrograming
{
    [TestClass]
    public class NumberSolitaireTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, -2, 0, 9, -1, -2 }, 8)]
        public void FindShouldReturnMaximalSum(int[] a, int expected)
        {
            NumberSolitaire finder = new NumberSolitaire();
            int actual = finder.Find(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

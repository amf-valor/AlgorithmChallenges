using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class TapeEquilibriumMinimizerTests
    {
        [TestMethod]
        public void ShouldReturn3()
        {
            int[] a = new int[] { 3, 6 };

            TapeEquilibriumMinimizer minimizer = new TapeEquilibriumMinimizer();

            int actual = minimizer.Minimize(a);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1()
        {
            int[] a = new int[] { 3, 1, 2, 4, 3 };

            TapeEquilibriumMinimizer minimizer = new TapeEquilibriumMinimizer();

            int actual = minimizer.Minimize(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn4WithNegativeNumbers()
        {
            int[] a = new int[] { -3, 3, 1, 2, 4, 3 };

            TapeEquilibriumMinimizer minimizer = new TapeEquilibriumMinimizer();

            int actual = minimizer.Minimize(a);
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }
}

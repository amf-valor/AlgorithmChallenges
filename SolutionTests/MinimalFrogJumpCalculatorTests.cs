using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class MinimalFrogJumpCalculatorTests
    {
        [TestMethod]
        public void ShouldReturn3()
        {
            MinimalFrogJumpCalculator calculator = new MinimalFrogJumpCalculator();
            int actual = calculator.Calculate(10, 85, 30);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0WhenXAndYAreEqual()
        {
            MinimalFrogJumpCalculator calculator = new MinimalFrogJumpCalculator();
            int actual = calculator.Calculate(85, 85, 30);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}

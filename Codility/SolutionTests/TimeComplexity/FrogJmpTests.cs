using AlgorithmChallenges.Codility.Solutions.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests.TimeComplexity
{
    [TestClass]
    public class FrogJmpTests
    {
        [TestMethod]
        [DataRow(85, 85, 30, 0, DisplayName = "CalculateShouldReturn0WhenXAndYAreSamePosition")]
        [DataRow(10, 85, 30, 3, DisplayName ="CalculateShouldReturn3WhenXis10Yis85AndDis30")]
        public void CalculateShouldReturnMinimalNumberOfJumpsWhenGivenPositionXandYAndDdistance(int x, int y, int d, int expected)
        {
            FrogJmp calculator = new FrogJmp();
            int actual = calculator.Calculate(x, y, d);
            Assert.AreEqual(expected, actual);
        }
    }
}

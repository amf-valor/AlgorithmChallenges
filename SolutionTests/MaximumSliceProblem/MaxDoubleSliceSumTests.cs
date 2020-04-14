using AlgorithmChallenges.Codility.Solutions.MaximumSliceProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmChallenges.Codility.SolutionTests.MaximumSliceProblem
{
    [TestClass]
    public class MaxDoubleSliceSumTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17, DisplayName = "example test")]
        [DataRow(new int[] { 3, 2, 6 }, 0, DisplayName = "ShouldCalculate0For3Elements")]
        [DataRow(new int[] { 3, 2, 6, 2, -8, 20, 40 }, 30, DisplayName = "ShouldCalculate33ForRandom")]
        [DataRow(new int[] { -7, 2, 6, 2 }, 6, DisplayName = "ShouldCalculate6ForMinimumInTheBegining")]
        [DataRow(new int[] { 6, 2, 8, -2 }, 8, DisplayName = "ShouldCalculate8ForMinimumInTheEnd")]
        [DataRow(new int[] { -2, -4, -5, -2, -6 }, 0, DisplayName = "ShouldCalculate0ForAllNegativeNumbers")]
        [DynamicData(nameof(GenerateData), DynamicDataSourceType.Method)]
        public void ShoulCalculateMaxSum(int[] A, int expected)
        {
            MaxDoubleSliceSum calculator = new MaxDoubleSliceSum();
            int actual = calculator.Calculate(A);
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GenerateData()
        {

            yield return new object[] { GenerateMaximumArray(), 999970000  };
        }

        private static int[] GenerateMaximumArray()
        {
            int[] maximumArray = new int[100000];

            for (int i = 0; i < maximumArray.Length; i++)
            {
                maximumArray[i] = 10000;
            }

            return maximumArray;
        }
    }
}

using AlgorithmChallenges.Codility.Solutions;
using AlgorithmChallenges.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class MaxCounterTests
    {
        [TestMethod]
        public void ShouldMaxCounters32242()
        {
            MaxCounter counter = new MaxCounter();
            int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            int[] expected = new int[] {3, 2, 2, 4, 2 };
            int[] actual = counter.Count(5, A);
            CollectionAssert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void MaxCountersPerformance()
        {
            int[] a = new int[10000];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 10001;
            }


            MaxCounter counter = new MaxCounter();
            TimeSpan actual = Helpers.Measure(() => counter.Count(10000, a));

            Assert.IsTrue(actual <= TimeSpan.FromSeconds(0.190));
        }
    }
}

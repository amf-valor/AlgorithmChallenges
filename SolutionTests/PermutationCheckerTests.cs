using AlgorithmChallenges.Codility.Solutions;
using AlgorithmChallenges.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class PermutationCheckerTests
    {
        [TestMethod]
        public void ShouldReturn1()
        {
            PermutationChecker checker = new PermutationChecker();
            int actual = checker.Check(new int[] { 4, 1, 3, 2 });
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0()
        {
            PermutationChecker checker = new PermutationChecker();
            int actual = checker.Check(new int[] { 4, 1, 3});
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1EvenWithOneElement()
        {
            PermutationChecker checker = new PermutationChecker();
            int actual = checker.Check(new int[] { 1 });
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0EvenWithOneElement()
        {
            PermutationChecker checker = new PermutationChecker();
            int actual = checker.Check(new int[] { 3 });
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldDelayLessThan150MilliSeconds()
        {
            int[] a = new int[100000];
            Random randNum = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(1, 1000000000);
            }


            PermutationChecker checker = new PermutationChecker();
            TimeSpan actual = Helpers.Measure(() => checker.Check(a));

            Assert.IsTrue(actual < TimeSpan.FromSeconds(0.150));
        }
    }
}

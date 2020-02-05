using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmChallenges.Codility.Solutions;
using AlgorithmChallenges.Common;

namespace CodingUtilityTests
{
    [TestClass]
    public class MissingIntergerDetectorTests
    {
        [TestMethod]
        public void ShouldReturn5()
        {
            int[] a = new int[] { 1, 3, 6, 4, 1, 2 };

            MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn4()
        {
            int[] a = new int[] { 1, 2, 3};

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1()
        {
            int[] a = new int[] { -3, -1};

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenLess1()
        {
            int[] a = new int[] { -1 };

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenNegativeAndPositive()
        {
            int[] a = new int[] {-7,-5,-1,3 };

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenNull()
        {
            int[] a = null;

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenEmpty()
        {
            int[] a = new int[] { };

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn3WithExtreme()
        {
            int[] a = new int[] { -1000000, 5, 8, 1000000, -2, 1, 2 };

           MissingIntergerDetector detector = new MissingIntergerDetector();

            int actual = detector.Detect(a);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumNPerformance()
        {
            int[] a = new int[100000];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(-1000000, 1000000);
            }


           MissingIntergerDetector detector = new MissingIntergerDetector();
            TimeSpan actual = Helpers.Measure(() => detector.Detect(a));
            
            Assert.IsTrue(actual <= TimeSpan.FromSeconds(2));
        }
    }
}

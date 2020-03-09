using AlgorithmChallenges.Codility.Solutions;
using AlgorithmChallenges.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class DivCounterTests
    {
        [TestMethod]
        public void ShouldReturn3()
        {
            DivCounter counter = new DivCounter();
            int expected = 3;
            int actual = counter.Count(6, 11, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn2()
        {
            DivCounter counter = new DivCounter();
            int expected = 2;
            int actual = counter.Count(6, 12, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn0()
        {
            DivCounter counter = new DivCounter();
            int expected = 0;
            int actual = counter.Count(4, 4, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenAB0()
        {
            DivCounter counter = new DivCounter();
            int expected = 1;
            int actual = counter.Count(0, 0, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn8()
        {
            DivCounter counter = new DivCounter();
            int expected = 8;
            int actual = counter.Count(0, 14, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn7()
        {
            DivCounter counter = new DivCounter();
            int expected = 7;
            int actual = counter.Count(0, 13, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn8WhenBoundaireIsReached()
        {
            DivCounter counter = new DivCounter();
            int expected = 8;
            int actual = counter.Count(0, 15, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1()
        {
            DivCounter counter = new DivCounter();
            int expected = 1;
            int actual = counter.Count(11, 13, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn1WhenABis1()
        {
            DivCounter counter = new DivCounter();
            int expected = 1;
            int actual = counter.Count(1, 1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn2000000001()
        {
            DivCounter counter = new DivCounter();
            int expected = 200000001;
            int actual = counter.Count(0, 200000000, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn200000000()
        {
            DivCounter counter = new DivCounter();
            int expected = 200000000;
            int actual = counter.Count(1, 200000000, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn12345()
        {
            DivCounter counter = new DivCounter();
            int expected = 12345;
            int actual = counter.Count(101, 123456789, 10000);

            Assert.AreEqual(expected, actual);
        }
    }
}

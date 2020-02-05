using System;
using CodilityTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUtilityTests
{
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        public void ShouldConvertToBinary9()
        {
            string expected = "1001";
            string actual = Helpers.ToBinary(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldConvertToBinary529()
        {
            string expected = "1000010001";
            string actual = Helpers.ToBinary(529);

            Assert.AreEqual(expected, actual);
        }
    }
}

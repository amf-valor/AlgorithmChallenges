using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class ChineseFloorAssignerTests
    {

        [TestMethod]
        public void ShouldReturn1()
        {
            ChineseFloorAssigner assigner = new ChineseFloorAssigner();
            int actual = assigner.Assign(1);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn5()
        {
            ChineseFloorAssigner assigner = new ChineseFloorAssigner();
            int actual = assigner.Assign(4);
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn12()
        {
            ChineseFloorAssigner assigner = new ChineseFloorAssigner();
            int actual = assigner.Assign(11);
            int expected = 12;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn15()
        {
            ChineseFloorAssigner assigner = new ChineseFloorAssigner();
            int actual = assigner.Assign(12);
            int expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn666()
        {
            ChineseFloorAssigner assigner = new ChineseFloorAssigner();
            int actual = assigner.Assign(440);
            int expected = 666;

            Assert.AreEqual(expected, actual);
        }
    }
}

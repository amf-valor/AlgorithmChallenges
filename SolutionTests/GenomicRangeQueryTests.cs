using AlgorithmChallenges.Codility.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmChallenges.Codility.SolutionTests
{
    [TestClass]
    public class GenomicRangeQueryTests
    {
        [TestMethod]
        public void ShouldReturn241()
        {
            GenomicRangeQuery query = new GenomicRangeQuery();
            int[] P = new int[] { 2, 5, 0 };
            int[] Q = new int[] { 4, 5, 6 };
            string dna = "CAGCCTA";
            int[] expected = { 2,4,1 };
            int[] actual = query.Query(dna, P, Q);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void ShouldReturn1()
        {
            GenomicRangeQuery query = new GenomicRangeQuery();
            int[] P = new int[] { 0 };
            int[] Q = new int[] { 0 };
            string dna = "A";
            int[] expected = { 1 };
            int[] actual = query.Query(dna, P, Q);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void ShouldQueryAllRanges()
        {
            GenomicRangeQuery query = new GenomicRangeQuery();
            int[] P = new int[] { 0, 1, 2, 3 };
            int[] Q = new int[] { 0, 1, 2, 3 };
            string dna = "ACGT";
            int[] expected = { 1,2,3,4 };
            int[] actual = query.Query(dna, P, Q);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void ShouldReturn112()
        {
            GenomicRangeQuery query = new GenomicRangeQuery();
            int[] P = new int[] { 0, 0, 1 };
            int[] Q = new int[] { 0, 1, 1 };
            string dna = "AC";
            int[] expected = { 1, 1, 2 };
            int[] actual = query.Query(dna, P, Q);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}

using AlgorithmChallenges.Codility.Solutions.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmChallenges.Codility.SolutionTests.PrefixSums
{
    [TestClass]
    public class GenomicRangeQueryTests
    {
        [TestMethod]
        [DataRow("AC", new int[] { 0, 0, 1 }, new int[] { 0, 1, 1 }, new int[] { 1, 1, 2 }, DisplayName = "QueryShouldReturnMinimalNucleotoideWhenGivenRangeHasAllPossibleQueries")]
        [DataRow("A", new int[] { 0 }, new int[] { 0 }, new int[] { 1 }, DisplayName = "QueryShouldReturnOneWhenGivenDNAHasOneFactorAndRangeAre0And0")]
        [DataRow("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 }, DisplayName = "QueryShouldReturnMinimalNucleotoideWhenGivenDNAAndRandomRanges")]
        public void QueryShouldReturnMinimalNucleotoideWhenGivenDNAAndRange(string dna, int[] p, int[] q, int[] expected)
        {
            GenomicRangeQuery query = new GenomicRangeQuery();
            int[] actual = query.Query(dna, p, q);
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}

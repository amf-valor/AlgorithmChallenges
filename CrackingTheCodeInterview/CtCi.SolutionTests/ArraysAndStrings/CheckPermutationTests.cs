using CtCi.Solutions.ArraysAndStrings;
using Xunit;

namespace CtCi.SolutionTests.ArraysAndStrings
{
    public class CheckPermutationTests
    {
        [Theory]
        [InlineData("aaa", null, false)]
        [InlineData(null, "bbb", false)]
        [InlineData(null, null, false)]
        [InlineData("aaa", "", false)]
        [InlineData("", "bbb", false)]
        [InlineData("", "", false)]
        [InlineData("aaa", "bbb", false)]
        [InlineData("abc", "bca", true)]
        [InlineData("aaa", "bb", false)]
        [InlineData("bba", "bbb", false)]
        public void CheckPermutationShoulReturnTrueOrFalseWhenGivenOneAndOtherStrings(string one, string other, bool expected) 
        {
            CheckPermutation checkPermutation = new CheckPermutation();
            bool actual = checkPermutation.IsPermutation(one, other);
            Assert.Equal(expected, actual);
        }
    }
}

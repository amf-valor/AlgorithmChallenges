using CtCi.Solutions.ArraysAndStrings;
using Xunit;

namespace CtCi.SolutionTests.ArraysAndStrings
{
    public class IsUniqueTests
    {
        [Theory]
        [InlineData("abcd", true)]
        [InlineData("aacd", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void EvaluateShouldReturnTrueOrFalseWhenGivenAnyString(string any, bool expected) 
        {
            IsUnique isUnique = new IsUnique();
            bool actual = isUnique.Evaluate(any);
            Assert.Equal(expected, actual);
        }
    }
}

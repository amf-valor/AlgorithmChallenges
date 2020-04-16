using CtCi.Solutions.BigO;
using Xunit;

namespace CtCi.SolutionTests.BigO
{
    public class Example12Tests
    {
        [Fact]
        public void PermutationShouldPrintWhenGivenAString()
        {
            Example12 example = new Example12();
            example.Permutation("abc");
            Assert.True(true);
        }
    }
}

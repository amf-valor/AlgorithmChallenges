using CtCi.Solutions.ArraysAndStrings;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CtCi.SolutionTests.ArraysAndStrings
{
    public class RotateMatrixTests
    {
        [Theory]
        [MemberData(nameof(Rotate90DegreeTestData))]
        public void Rotate90DegreeShouldRotateGivenMatrix(int[][] squareMatrix, int[][] expected)
        {
            RotateMatrix rotate = new RotateMatrix(squareMatrix);
            int[][] actual = rotate.Rotate90Degree();
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Rotate90DegreeTestData =>
            new List<object[]>
            {
                new object[]
                {
                    new int[][]
                    {
                        new int []{ 1, 2, 3, 4 },
                        new int []{ 5, 6, 7, 8},
                        new int []{ 9, 10, 11, 12 },
                        new int []{ 31, 10, 15, 200},
                    },
                    new int [][]
                    { 
                        new int []{ 4, 8, 12, 200 },
                        new int []{ 3, 7, 11, 15 },
                        new int []{ 2, 6 ,10, 10 },
                        new int []{ 1, 5, 9, 31 }
                    }
                }
            };
    }
}

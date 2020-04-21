using CtCi.Solutions.LinkedLists;
using System;
using System.Collections.Generic;
using Xunit;

namespace CtCi.SolutionTests.LinkedLists
{
    public class RemoveDupsTests
    {
        [Theory]
        [MemberData(nameof(RemoveDuplicatedValuesTestData))]
        public void DistinctShouldRemoveDuplicatedValuesWhenGivenALinkedList(LinkedList<int> actual, LinkedList<int> expected) 
        {
            actual.Distinct();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ShouldThrowArgumentExceptionTestData))]
        public void DistinctShouldThrowArgumentExceptionWhenLinkedListIsNullOrEmpty(LinkedList<int> actual) 
        {
            Assert.Throws<ArgumentException>(() => actual.Distinct());
        }

        public static IEnumerable<object[]> RemoveDuplicatedValuesTestData =>
            new List<object[]> 
            {
                new object[]
                {
                    new LinkedList<int>(new int[] { 1, 1, 2, 2 }),
                    new LinkedList<int>(new int[] { 1, 2 })
                },
                new object[]
                {
                    new LinkedList<int>(new int[] { 1, 2, 1, 3 }),
                    new LinkedList<int>(new int[] { 1, 2, 3 })
                },
                new object[]
                {
                    new LinkedList<int>(new int[] { 1, 2, 1, 3, 2, 3, 3 }),
                    new LinkedList<int>(new int[] { 1, 2, 3 })
                }
            };

        public static IEnumerable<object[]> ShouldThrowArgumentExceptionTestData =>
            new List<object[]> 
            { 
                new object[]
                {
                    new LinkedList<int>(new int[]{ }),
                },
                new object[]
                {
                    null,
                }
            };
    }
}

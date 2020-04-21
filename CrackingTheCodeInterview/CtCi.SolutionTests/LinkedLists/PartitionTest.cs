using CtCi.Solutions.LinkedLists;
using System;
using System.Collections.Generic;
using Xunit;

namespace CtCi.SolutionTests.LinkedLists
{
    public class PartitionTest
    {
        [Theory]
        [MemberData(nameof(PartionedLinkedListAroundXTestData))]
        public void ToPartitionShouldReturnPartionedLinkedListAroundXWhenGivenXandALinkedList(int x, LinkedList<int> aLinkedList, LinkedList<int> expected) 
        {
            Partition partitioner = new Partition();
            LinkedList<int> actual = partitioner.ToPartition(x, aLinkedList);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ThrowsArgumentExceptionTestData))]
        public void ToPartitionShouldThrowsArgumentExceptionWhenGivenALinkedListIsNullOrEmpty(int x, LinkedList<int> aLinkedList) 
        {
            Partition partioner = new Partition();
            Func<int, LinkedList<int>, LinkedList<int>> actual = partioner.ToPartition;
            Assert.Throws<ArgumentException>(() => actual(x, aLinkedList));
        }

        public static IEnumerable<object[]> PartionedLinkedListAroundXTestData =>
            new List<object[]>
            {
                new object[]
                {
                  5,
                  new LinkedList<int>(new int[]{ 3, 5, 8, 5, 10, 2, 1 }),
                  new LinkedList<int>(new int[]{ 1, 2, 3, 5, 8, 5, 10 })
                },
                new object[]
                {
                  10,
                  new LinkedList<int>(new int[]{ 5, 30, 6, 15}),
                  new LinkedList<int>(new int[]{ 6, 5, 30, 15})
                }

            };

        public static IEnumerable<object[]> ThrowsArgumentExceptionTestData =>
            new List<object[]>
            {
                new object[]
                { 
                    0, null
                },
                new object[]
                { 
                    1, new LinkedList<int>()
                }
            };
    }
}

using CtCi.Solutions.LinkedLists;
using System;
using System.Collections.Generic;
using Xunit;

namespace CtCi.SolutionTests.LinkedLists
{
    public class PalindromeTests
    {
        [Theory]
        [MemberData(nameof(ReturnTrueOrFalseTestData))]
        public void IsPalindromeShouldReturnTrueOrFalseWhenGivenALinkedList<T>(LinkedList<T> aLinkedList, bool expected) 
        {
            Palindrome palindrome = new Palindrome();
            bool actual = palindrome.IsPalindrome(aLinkedList);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ThrowsArgumentExceptionTestData))]
        public void IsPalindromeShoulThrowsExceptionWhenALinkedListIsNullOrEmpty<T>(LinkedList<T> aLinkedList) 
        {
            Palindrome palindrome = new Palindrome();
            Func<LinkedList<T>, bool> actual = palindrome.IsPalindrome;
            Assert.Throws<ArgumentException>(() => actual(aLinkedList));
        }

        public static IEnumerable<object[]> ReturnTrueOrFalseTestData =>
            new List<object[]> 
            { 
                new object[]
                {
                    new LinkedList<int>(new int[]{ 1, 2, 1 }),
                    true
                },
                 new object[]
                {
                    new LinkedList<int>(new int[]{ 1, 3, 4 }),
                    false
                },
                new object[]
                {
                    new LinkedList<char>("civic"),
                    true
                },
                new object[]
                {
                    new LinkedList<char>("test"),
                    false
                },
                new object[]
                {
                    new LinkedList<char>("redivider"),
                    true
                },
                new object[]
                {
                    new LinkedList<char>("aa"),
                    true
                },
                new object[]
                {
                    new LinkedList<char>("ab"),
                    false
                },
                new object[]
                {
                    new LinkedList<char>("a"),
                    true
                },
            };

        public static IEnumerable<object[]> ThrowsArgumentExceptionTestData =>
            new List<object[]>
            {
                new object[]
                {
                    null
                },
                new object[]
                {
                    new LinkedList<int>()
                },
            };
    }
}

using InterviewPreparationKit.Tasks.Search;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Search
{
    public class IceCreamParlorTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, 2, "1 2")]
        [InlineData(new int[] { 1, 4, 5, 3, 2 }, 4, "1 4")]
        [InlineData(new int[] { 4, 3, 2, 5, 7 }, 8, "2 4")]
        [InlineData(new int[] { 7, 2, 5, 4, 11 }, 12, "1 3")]
        [InlineData(new int[] { 7, 2, 5, 9, 5 }, 10, "3 5")]
        [InlineData(new int[] { 8, 2, 6 }, 8, "2 3")]
        public void ProperlyListsFlavors(int[] cost, int money, string expected)
        {
            string actual = IceCreamParlor.WhatFlavors(cost, money);

            Assert.Equal(expected, actual);
        }
    }
}
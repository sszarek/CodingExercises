using System.Collections.Generic;
using System.IO;
using System.Linq;
using InterviewPreparationKit.Tasks.DynamicProgramming;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.DynamicProgramming
{
    public class MaxArraySumTests
    {
        [Theory]
        [InlineData(new int[] { -2, 1, 3, -4, 5 }, 8)]
        [InlineData(new int[] { 3, 7, 4, 6, 5 }, 13)]
        [InlineData(new int[] { 3, 5, -7, 8, 10 }, 15)]
        [InlineData(new int[] { 5, -3, -3, -7, 8, 10 }, 15)]
        [InlineData(new int[] { 2, 1, 10, 1 }, 12)]
        [InlineData(new int[] { 1, 2, 10, 2, -10 }, 11)]
        public void ProperlyCalculatesMaxSum(int[] arr, int expected)
        {
            int actual = MaxArraySum.MaxSubsetSum(arr);

            Assert.Equal(expected, actual);
        }
    }
}
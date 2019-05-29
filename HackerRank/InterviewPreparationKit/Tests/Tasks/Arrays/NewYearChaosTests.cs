using InterviewPreparationKit.Tasks.Arrays;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Arrays
{
    public class NewYearChaosTests
    {
        private void AssertProperSolution(int[] queue, int expected)
        {
            //When
            int output = NewYearChaos.MinimumBribes(queue);

            //Then
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 1, 2 }, 0)]
        public void SortedQueue_Returns0(int[] queue, int expected)
        {
            AssertProperSolution(queue, expected);
        }

        [Theory]
        [InlineData(new int[] { 2, 1 }, 1)]
        [InlineData(new int[] { 1, 3, 2 }, 1)]
        [InlineData(new int[] { 3, 1, 2 }, 2)]
        [InlineData(new int[] { 2, 1, 5, 3, 4 }, 3)]
        public void UnsortedQueue_ReturnsNumberOfBribes(int[] queue, int expected)
        {
            AssertProperSolution(queue, expected);
        }

        [Theory]
        [InlineData(new int[] { 2, 5, 1, 3, 4 }, -1)]
        public void Impossible_ReturnsMinusOne(int[] queue, int expected)
        {
            AssertProperSolution(queue, expected);
        }
    }
}
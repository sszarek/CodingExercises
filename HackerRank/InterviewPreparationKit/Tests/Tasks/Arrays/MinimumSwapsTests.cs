using InterviewPreparationKit.Tasks.Arrays;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Arrays
{
    public class MinimumSwapsTests
    {
        private void AssertMinimumSwaps(int[] input, int expected)
        {
            //When
            var actual = MinimumSwaps.CalculateMinimumSwaps(input);

            //Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArrayEmpty_ReturnsZero()
        {
            AssertMinimumSwaps(new int[0], 0);
        }

        [Fact]
        public void SingleElement_ReturnsZero()
        {
            AssertMinimumSwaps(new int[] { 1 }, 0);
        }

        [Fact]
        public void SortedArray_ReturnsZero()
        {
            AssertMinimumSwaps(new int[] { 1, 2, 3 }, 0);
        }

        [Theory]
        [InlineData(new int[] { 2, 1 }, 1)]
        [InlineData(new int[] { 7, 1, 3, 2, 4, 5, 6 }, 5)]
        [InlineData(new int[] { 4, 3, 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3, 4, 1, 5 }, 3)]
        public void ProperyCalculatesMinimumSwaps(int[] input, int expected)
        {
            AssertMinimumSwaps(input, expected);
        }
    }
}
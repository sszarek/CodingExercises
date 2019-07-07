using InterviewPreparationKit.Tasks.Greedy;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Greedy
{
    public class MinimumAbsoluteDiffTests
    {
        [Fact]
        public void TwoNumbers_ReturnsDiff()
        {
            //Given
            int[] arr = new int[] { 2, 1 };

            //When
            int actual = MinimumAbsoluteDiff.MinimumAbsoluteDifference(arr);

            //Then
            Assert.Equal(1, actual);
        }

        [Theory]
        [InlineData(new int[] { 3, -7, 0 }, 3)]
        [InlineData(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }, 1)]
        [InlineData(new int[] { 1, -3, 71, 68, 17 }, 3)]
        public void ProperlyFindsMinimumAbsoluteDiff(int[] arr, int expected)
        {
            int actual = MinimumAbsoluteDiff.MinimumAbsoluteDifference(arr);

            Assert.Equal(expected, actual);
        }
    }
}
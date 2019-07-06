using InterviewPreparationKit.Tasks.Search;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Search
{
    public class PairsTests
    {
        [Fact]
        public void TwoNumbersFormingDiff_ReturnsOne()
        {
            //Given
            int[] arr = new int[] { 1, 2 };
            int k = 1;

            //When
            int actual = Pairs.CountPairs(k, arr);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void ThreeNumbersFormingDiff_ReturnsTwo()
        {
            //Given
            int[] arr = new int[] { 1, 2, 3 };
            int k = 1;

            //When
            int actual = Pairs.CountPairs(k, arr);

            //Then
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3, 4, 2 }, 2, 3)]
        public void ProperlyCountsDifferences(int[] arr, int k, int expected)
        {
            int actual = Pairs.CountPairs(k, arr);

            Assert.Equal(expected, actual);
        }
    }
}
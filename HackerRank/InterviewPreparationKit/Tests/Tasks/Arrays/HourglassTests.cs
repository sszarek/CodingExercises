using InterviewPreparationKit.Tasks.Arrays;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Arrays
{
    public class HourglassTests
    {
        [Fact]
        public void ArrayOfZeros_ReturnsZero()
        {
            //Given
            var input = new int[][] {
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
            };

            //When
            var sum = Hourglass.HourglassSum(input);

            //Then
            Assert.Equal(0, sum);
        }

        [Fact]
        public void SingleHourglass_Returns7()
        {
            //Given
            var input = new int[][] {
                new int[]{1,1,1,0,0,0},
                new int[]{0,1,0,0,0,0},
                new int[]{1,1,1,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
            };

            //When
            var sum = Hourglass.HourglassSum(input);

            //Then
            Assert.Equal(7, sum);
        }

        [Fact]
        public void SingleHourglassNonStarting_Return7()
        {
            //Given
            var input = new int[][] {
                new int[]{0,0,0,0,0,0},
                new int[]{0,1,1,1,0,0},
                new int[]{0,0,1,0,0,0},
                new int[]{0,1,1,1,0,0},
                new int[]{0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0},
            };

            //When
            var sum = Hourglass.HourglassSum(input);

            //Then
            Assert.Equal(7, sum);
        }
    }
}
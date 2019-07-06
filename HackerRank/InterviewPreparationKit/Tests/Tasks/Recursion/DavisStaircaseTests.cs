using InterviewPreparationKit.Tasks.Recursion;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Recursion
{
    public class DavisStaircaseTests
    {
        [Fact]
        public void SingleStep_ReturnsOne()
        {
            //When
            int actual = DavisStaircase.StepsPerm(1);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TwoSteps_ReturnsTwo()
        {
            //When
            int actual = DavisStaircase.StepsPerm(2);

            //Then
            Assert.Equal(2, actual);
        }

        [Fact]
        public void ThreeSteps_ReturnsFour()
        {
            //When
            int actual = DavisStaircase.StepsPerm(3);

            //Then
            Assert.Equal(4, actual);
        }

        [Theory]
        [InlineData(4, 7)]
        [InlineData(5, 13)]
        public void ProperlyCalculatesNumberOfSteps(int n, int expected)
        {
            //When
            int actual = DavisStaircase.StepsPerm(n);

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
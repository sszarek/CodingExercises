using InterviewPreparationKit.Tasks.Recursion;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Recursion
{
    public class RecursiveDigitSumTests
    {
        [Fact]
        public void SingleDigit_ReturnsSameNumber()
        {
            //Given
            string n = "1";
            int k = 1;

            //When
            int actual = RecursiveDigitSum.SuperDigit(n, k);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TwoDigits_ReturnsSum()
        {
            //Given
            string n = "12";
            int k = 1;

            //When
            int actual = RecursiveDigitSum.SuperDigit(n, k);

            //Then
            Assert.Equal(3, actual);
        }

        [Fact]
        public void TwoLargeDigits_ReturnsSum()
        {
        //Given
            string n = "99";
            int k = 1;

            //When
            int actual = RecursiveDigitSum.SuperDigit(n, k);

            //Then
            Assert.Equal(9, actual);
        }
    }
}
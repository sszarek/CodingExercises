using InterviewPreparationKit.Tasks.Strings;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Strings
{
    public class CommonChildTests
    {
        [Fact]
        public void TwoSameLetters_ReturnsOne()
        {
            //Given
            var s1 = "A";
            var s2 = "A";

            //When
            var actual = CommonChild.CalculateLongestChildLength(s1, s2);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TwoDifferentLetters_ReturnsZero()
        {
            //Given
            var s1 = "A";
            var s2 = "B";

            //When
            var actual = CommonChild.CalculateLongestChildLength(s1, s2);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void ThreeLetterString_ReturnsTwo()
        {
            //Given
            var s1 = "ABCD";
            var s2 = "ACBD";

            //When
            var actual = CommonChild.CalculateLongestChildLength(s1, s2);

            //Then
            Assert.Equal(3, actual);
        }

        [Theory]
        [InlineData("SHINCHAN", "NOHARAAA", 3)]
        [InlineData("ABAB", "BABA", 3)]
        [InlineData("FOO", "FOO", 3)]
        [InlineData("AA", "BB", 0)]
        [InlineData("ABCDEFG", "ABEFGCD", 5)]
        public void ProperlyCalculatesLongestChild(string s1, string s2, int expected)
        {
            //When
            var actual = CommonChild.CalculateLongestChildLength(s1, s2);

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
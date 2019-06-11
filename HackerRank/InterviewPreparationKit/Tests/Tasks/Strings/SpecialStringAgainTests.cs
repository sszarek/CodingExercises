using InterviewPreparationKit.Tasks.Strings;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Strings
{
    public class SpecialStringAgainTests
    {
        [Fact]
        public void SingleLetter_ReturnsOne()
        {
            //Given
            var input = "a";

            //When
            var actual = SpecialStringAgain.SubstringCount(input);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TwoDistinctLetters_ReturnsTwo()
        {
            //Given
            var input = "ab";

            //When
            var actual = SpecialStringAgain.SubstringCount(input);

            //Then
            Assert.Equal(2, actual);
        }

        [Fact]
        public void TwoSameLetters_ReturnsThree()
        {
            //Given
            var input = "aa";

            //When
            var actual = SpecialStringAgain.SubstringCount(input);

            //Then
            Assert.Equal(3, actual);
        }

        [Theory]
        [InlineData("asasd", 7)]
        [InlineData("abcbaba", 10)]
        [InlineData("aaaa", 10)]
        public void ProperlyCountsSubstrings(string input, long expected)
        {
            var actual = SpecialStringAgain.SubstringCount(input);

            Assert.Equal(expected, actual);
        }
    }
}

using InterviewPreparationKit.Tasks.Strings;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Strings
{
    public class SherlockAndValidStringTests
    {
        [Fact]
        public void SingleLetter_ReturnsTrue()
        {
            //Given
            var input = "a";

            //When
            var actual = SherlockAndValidString.IsValid(input);

            //Then
            Assert.True(actual);
        }

        [Fact]
        public void TwoDistinctLetters_ReturnsTrue()
        {
            //Given
            var input = "ab";

            //When
            var actual = SherlockAndValidString.IsValid(input);

            //Then
            Assert.True(actual);
        }

        [Theory]
        [InlineData("abc", true)]
        [InlineData("abb", true)]
        [InlineData("abbb", true)]
        [InlineData("abccc", false)]
        [InlineData("abbcc", true)]
        [InlineData("aaaa", true)]
        [InlineData("aabbccddeefghi", false)]
        [InlineData("abcdefghhgfedecba", true)]
        public void ProperlyValidatesString(string input, bool expected)
        {
            var actual = SherlockAndValidString.IsValid(input);

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
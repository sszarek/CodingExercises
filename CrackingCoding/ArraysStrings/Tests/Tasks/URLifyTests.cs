using ArraysStrings.Tasks;
using Xunit;

namespace ArraysStrings.Tests
{
    public class URLifyTests
    {
        [Fact]
        public void ShouldProperlyEncodeSingleSpace()
        {
            //Given
            var input = "   ";
            //When
            var output = URLify.EncodeUrl(input);
            //Then
            Assert.Equal("%20", output);
        }

        [Fact]
        public void ShouldProperlyEncodeTwoWordsWithSpace()
        {
            //Given
            var input = "Hello world  ";
            //When  
            var output = URLify.EncodeUrl(input);
            //Then
            Assert.Equal("Hello%20world", output);
        }
    }
}
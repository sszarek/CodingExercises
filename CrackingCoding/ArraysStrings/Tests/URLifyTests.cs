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
            var input = " ";
        //When
            var output = URLify.EncodeUrl(input);
        //Then
            Assert.Equal("%20", output);
        }
    }
}
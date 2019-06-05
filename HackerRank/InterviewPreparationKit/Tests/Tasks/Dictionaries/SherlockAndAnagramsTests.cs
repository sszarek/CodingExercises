using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class SherlockAndAnagramsTests
    {
        [Theory]
        [InlineData("aa", 1)]
        [InlineData("abba", 4)]
        [InlineData("ifailuhkqq", 3)]
        [InlineData("kkkk", 10)]
        public void AnagramsPresent_ReturnsNumberOfAnagrams(string str, int expected)
        {
            int actual = SherlockAndAnagrams.CountAnagrams(str);

            Assert.Equal(expected, actual);
        }
    }
}
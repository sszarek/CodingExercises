using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class TwoStringsTests
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abz", "a")]
        public void CommonSubstringPresent_ReturnsTrue(string s1, string s2)
        {
            Assert.True(TwoStrings.IsSharingSubstring(s1, s2));
        }

        [Theory]
        [InlineData("a", "b")]
        public void CommonSubstringNotPresent_ReturnsFalse(string s1, string s2)
        {
            Assert.False(TwoStrings.IsSharingSubstring(s1, s2));
        }
    }
}
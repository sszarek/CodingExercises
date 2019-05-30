using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class RansomeNoteTests
    {
        [Fact]
        public void SingleMatchingWord_ReturnsTrue()
        {
            //Given
            var magazine = new string[] { "hello" };
            var note = new string[] { "hello" };

            //When
            var output = RansomeNote.CheckMagazine(magazine, note);

            //Then
            Assert.True(output);
        }

        [Fact]
        public void SingleNotMatchingWord_ReturnsFalse()
        {
            //Given
            var magazine = new string[] { "hello" };
            var note = new string[] { "Hello" };

            //When
            var output = RansomeNote.CheckMagazine(magazine, note);

            //Then
            Assert.False(output);
        }
    }
}
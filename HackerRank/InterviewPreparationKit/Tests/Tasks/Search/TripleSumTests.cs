using InterviewPreparationKit.Tasks.Search;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Search
{
    public class TripleSumTests
    {
        [Theory]
        [InlineData(new int[] { 3, 5, 7 }, new int[] { 3, 6 }, new int[] { 4, 6, 9 }, 4)]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { 2, 3 }, new int[] { 1, 2, 3 }, 8)]
        [InlineData(new int[] { 1, 4, 5 }, new int[] { 2, 3, 3 }, new int[] { 1, 2, 3 }, 5)]
        public void ProperlyCountsTriplets(int[] a, int[] b, int[] c, long expected)
        {
            long actual = TripleSum.Triplets(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}
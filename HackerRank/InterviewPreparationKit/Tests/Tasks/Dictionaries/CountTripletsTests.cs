using System.Collections.Generic;
using System.Linq;
using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class CountTripletsTests
    {
        [Fact]
        public void EmptyList_ReturnsZero()
        {
            //Given
            var input = Enumerable.Empty<long>().ToList();

            //When
            var actual = CountTriplets.Count(input, 2);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void OneElementList_ReturnsZero()
        {
            //Given
            var input = new List<long>
            {
                1
            };

            //When
            var actual = CountTriplets.Count(input, 2);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void SingleTriplet_ReturnsOne()
        {
            //Given
            var input = new List<long>
            {
                1,2,4
            };

            //When
            var actual = CountTriplets.Count(input, 2);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void ThreeNumbersNotProgression_ReturnsZero()
        {
            //Given
            var input = new List<long>
            {
                1,2,8
            };

            //When
            var actual = CountTriplets.Count(input, 2);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void BaseEqualOne_ReturnsZero()
        {
            //Given
            var input = new List<long>
            {
                1,2,8
            };

            //When
            var actual = CountTriplets.Count(input, 1);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void ProgressionWithDuplicatedNumber_ReturnsTwo()
        {
            //Given
            var input = new List<long>
            {
                1,2,2,4
            };

            //When
            var actual = CountTriplets.Count(input, 2);

            //Then
            Assert.Equal(2, actual);
        }

        [Theory]
        // [InlineData(new long[] { 1, 3, 9, 9, 27, 81 }, 3, 6)]
        // [InlineData(new long[] { 1, 1, 2, 2, 4, 4 }, 2, 8)]
        // [InlineData(new long[] { 4, 2, 1 }, 2, 0)]
        // [InlineData(new long[] { 0, 0, 0 }, 2, 0)]
        [InlineData(new long[] { 1, 1, 1 }, 1, 1)]
        public void ProperlyCalculatesNumberOfTriplets(long[] arr, long r, long expected)
        {
            var input = arr.ToList();

            var actual = CountTriplets.Count(input, r);

            Assert.Equal(expected, actual);
        }
    }
}

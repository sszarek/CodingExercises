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
    }
}
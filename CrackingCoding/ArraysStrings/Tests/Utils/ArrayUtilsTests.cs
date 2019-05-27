using ArraysStrings.Utils;
using Xunit;

namespace ArraysStrings.Tests
{
    public class ArrayUtilsTests
    {
        [Fact]
        public void DoesNotShiftEmptyArray()
        {
            //Given
            var arr = new int[] { };
            //When
            var output = arr.ShiftRight(0, 1);

            //Then
            Assert.Equal(new int[] { }, output);
        }

        [Fact]
        public void DoesNotShiftArrayIfDeltaZero()
        {
            //Given
            var arr = new int[] { 1, 2 };

            //When
            var output = arr.ShiftRight(0, 0);

            //Then
            Assert.Equal(new int[] { 1, 2 }, output);
        }

        [Fact]
        public void ShiftsArrayInPlace()
        {
            //Given
            var arr = new int[] { 1, 2 };
            //When
            var output = arr.ShiftRight(0, 1);

            //Then
            Assert.Same(arr, output);
        }

        [Fact]
        public void ShiftsArrayByOne()
        {
            //Given
            var arr = new int[] { 1, 2 };

            //When
            var output = arr.ShiftRight(0, 1);

            //Then
            Assert.Equal(new int[] { 0, 1 }, output);
        }

        [Fact]
        public void ShiftsArrayByTwo()
        {
            //Given
            var arr = new int[] { 1, 2 };

            //When
            var output = arr.ShiftRight(0, 2);

            //Then
            Assert.Equal(new int[] { 0, 0 }, output);
        }

        [Fact]
        public void ShiftsArrayByOneStartingFromOne()
        {
            //Given
            var arr = new int[] { 1, 2 };
            //When
            var output = arr.ShiftRight(1, 1);

            //Then
            Assert.Equal(new int[] { 1, 0 }, output);
        }

        [Theory]
        [InlineData(2, 2, new int[] {1,2,3,4,5 }, new int[] {1,2,0,0,3 })]
        public void FirstTheory(int idx, int delta, int[] input, int[] expected)
        {
            var output = input.ShiftRight(idx, delta);

            Assert.Equal(expected, output);
        }
    }
}
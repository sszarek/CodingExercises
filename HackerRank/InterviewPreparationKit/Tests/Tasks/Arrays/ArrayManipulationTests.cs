using System.Collections.Generic;
using InterviewPreparationKit.Tasks.Arrays;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Arrays
{
    public class ArrayManipulationTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ShouldReturnMaximumValue(int n, int[][] queries, int expected)
        {
            long actual = ArrayManipulation.Manipulate(n, queries);

            Assert.Equal(expected, actual);
        }
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {
                    10, new int[][] {
                        new int[] {1,5,3},
                        new int[] {4,8,7},
                        new int[] {6,9,1}
                    }, 10
                }
            };
    }
}
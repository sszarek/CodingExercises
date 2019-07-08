using System.Collections.Generic;
using InterviewPreparationKit.Tasks.Greedy;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Greedy
{
    public class LuckBalanceTests
    {
        [Theory]
        [MemberData(nameof(Data), 10)]
        public void ProperlyCalculatesLuckBalance(int[][] contests, int k, int expected)
        {
            int actual = LuckBalance.CalculateLuckBalance(k, contests);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 
                    new int[][] {
                        new int[] {5,1},
                        new int[] {1,1},
                        new int[] {4,0}
                    }, 2, 10
                },
                new object[] { 
                    new int[][] {
                        new int[] {5,1},
                        new int[] {2,1},
                        new int[] {1,1},
                        new int[] {8,1},
                        new int[] {10,0},
                        new int[] {5,0}
                    }, 3, 29
                },
            };
    }
}
using System.Collections.Generic;
using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class FrequencyQueriesTests
    {
        private List<int> AddOp(int num) => new List<int> {
            1, num
        };

        private List<int> RemoveOp(int num) => new List<int> {
            2, num
        };

        private List<int> PrintOp(int num) => new List<int> {
            3, num
        };

        [Fact]
        public void SingleQueryWithMatch_ReturnsOne()
        {
            //Given
            var queries = new List<List<int>>{
                AddOp(1),
                PrintOp(1)
            };

            //When
            List<int> actual = FrequencyQueries.FreqQuery(queries);

            //Then
            Assert.Equal(new List<int> { 1 }, actual);
        }

        [Fact]
        public void SingleQueryWithNoMatch_ReturnsZero()
        {
            //Given
            var queries = new List<List<int>>{
                AddOp(1),
                PrintOp(2)
            };

            //When
            List<int> actual = FrequencyQueries.FreqQuery(queries);

            //Then
            Assert.Equal(new List<int> { 0 }, actual);
        }

        [Fact]
        public void QueryWithRemoval_ReturnsOne()
        {
            //Given
            var queries = new List<List<int>>{
                AddOp(1),
                AddOp(1),
                RemoveOp(1),
                PrintOp(1)
            };

            //When
            List<int> actual = FrequencyQueries.FreqQuery(queries);

            //Then
            Assert.Equal(new List<int> { 1 }, actual);
        }

        [Fact]
        public void QueryWithRemovalOfMissingItem_ReturnsZero()
        {
            //Given
            var queries = new List<List<int>>{
                AddOp(1),
                RemoveOp(2),
                PrintOp(2)
            };

            //When
            List<int> actual = FrequencyQueries.FreqQuery(queries);

            //Then
            Assert.Equal(new List<int> { 0 }, actual);
        }
    }
}
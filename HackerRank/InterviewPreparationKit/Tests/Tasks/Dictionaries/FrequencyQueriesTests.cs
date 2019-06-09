using System.Collections.Generic;
using InterviewPreparationKit.Tasks.Dictionaries;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Dictionaries
{
    public class FrequencyQueriesTests
    {
        [Fact]
        public void SingleQueryWithMatch_ReturnsOne()
        {
            //Given
            var queries = new List<List<int>>{
                new List<int>{
                    1,1
                },
                new List<int> {
                    3,1
                }
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
                new List<int>{
                    1,1
                },
                new List<int> {
                    3,2
                }
            };

            //When
            List<int> actual = FrequencyQueries.FreqQuery(queries);

            //Then
            Assert.Equal(new List<int> { 0 }, actual);
        }
    }
}
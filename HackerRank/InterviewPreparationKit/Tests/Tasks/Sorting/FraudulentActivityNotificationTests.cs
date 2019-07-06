using InterviewPreparationKit.Tasks.Sorting;
using Xunit;

namespace InterviewPreparationKit.Tests.Tasks.Sorting
{
    public class FraudulentActivityNotificationTests
    {
        [Fact]
        public void ThreeEntriesWithLegalOp_ReturnsZero()
        {
            //Given
            var expenditures = new int[] {
                2,4,5
            };

            //When
            int actual = FraudulentActivityNotification.ActivityNotifications(expenditures, 2);

            //Then
            Assert.Equal(0, actual);
        }

        [Fact]
        public void ThreeEntriesWithIllegalOp_ReturnsOne()
        {
            //Given
            var expenditures = new int[] {
                2,4,6
            };

            //When
            int actual = FraudulentActivityNotification.ActivityNotifications(expenditures, 2);

            //Then
            Assert.Equal(1, actual);
        }

        [Fact]
        public void FourEntriesWithIllegalOp_ReturnsTwo()
        {
            //Given
            var expenditures = new int[] {
                2,4,6,10
            };

            //When
            int actual = FraudulentActivityNotification.ActivityNotifications(expenditures, 2);

            //Then
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,4}, 4, 0)]
        public void ProperlyCountsIllegalOperations(int[] expenditures, int d, int expected)
        {
            int actual = FraudulentActivityNotification.ActivityNotifications(expenditures, d);

            Assert.Equal(expected, actual);
        }
    }
}
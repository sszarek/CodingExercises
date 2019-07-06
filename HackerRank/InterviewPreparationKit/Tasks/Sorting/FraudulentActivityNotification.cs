using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Sorting
{
    /// <Summary>
    /// Solution for <See href="https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting">Fraudulent Activity Notifications</See> problem.
    /// </Summary>
    public class FraudulentActivityNotification
    {
        public static int ActivityNotifications(int[] expenditures, int d)
        {
            int[] histogram = InitHistogram(expenditures, d);

            int illegalOperations = 0;
            for (var idx = d; idx < expenditures.Length; idx++)
            {
                int value = expenditures[idx];

                double median = 0;

                if (d % 2 == 0)
                {   
                    median = (
                        (double)FindInHistogram(histogram, d/2) +
                        (double)FindInHistogram(histogram, d/2 -1)
                    ) / 2;
                }
                else
                {
                    median = FindInHistogram(histogram, (int)Math.Floor((double)d / 2));
                }

                if (value >= median * 2)
                {
                    illegalOperations++;
                }
                UpdateHistogram(histogram, expenditures[idx - d], value);
            }
            return illegalOperations;
        }

        private static int[] InitHistogram(int[] expenditures, int d)
        {
            int[] histogram = new int[201]; // numbers are in range 0-200 (inclusive)
            for (int idx = 0; idx < d; idx++)
            {
                histogram[expenditures[idx]]++;
            }

            return histogram;
        }

        private static int FindInHistogram(int[] histogram, int index)
        {
            int counter = 0;
            for (int idx = 0; idx < histogram.Length; idx++)
            {
                if (histogram[idx] == 0)
                {
                    continue;
                }

                counter += histogram[idx];
                if (counter > index)
                {
                    return idx;
                }
            }

            return 0;
        }

        private static int[] GetTrailingExpenditures(int[] histogram, int d)
        {
            int[] expenditures = new int[d];
            int expenditureIdx = 0;

            for (int idx = 0; idx < histogram.Length; idx++)
            {
                int value = histogram[idx];
                if (value > 0)
                {
                    for (int j = 0; j < value; j++)
                    {
                        expenditures[expenditureIdx] = idx;
                        expenditureIdx++;
                    }

                    if (expenditureIdx == d)
                    {
                        break;
                    }
                }
            }

            return expenditures;
        }

        private static void UpdateHistogram(int[] histogram, int tail, int cur)
        {
            histogram[tail]--;
            histogram[cur]++;
        }
    }
}
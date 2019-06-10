using System;
using System.Collections.Generic;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Problem: <see href="https://www.hackerrank.com/challenges/frequency-queries/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Frequency Queries</see>.
    /// </Summary>
    public class FrequencyQueries
    {
        private static void Increase(Dictionary<int, int> dict, int key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        private static void Decrease(Dictionary<int, int> dict, int key)
        {
            if (dict.ContainsKey(key) && dict[key] > 0)
            {
                dict[key]--;
            }
        }

        private static bool CheckIfFrequencyPresent(Dictionary<int, int> counts, int frequency)
        {
            return counts.ContainsKey(frequency) && counts[frequency] > 0;
        }

        public static List<int> FreqQuery(List<List<int>> queries)
        {
            var numbers = new Dictionary<int, int>();
            var counts = new Dictionary<int, int>();
            var results = new List<int>();

            foreach (var query in queries)
            {
                var operation = query[0];
                var number = query[1];

                switch (operation)
                {
                    case 1:
                        if (numbers.ContainsKey(number))
                        {
                            Decrease(counts, numbers[number]);
                        }
                        Increase(numbers, number);
                        Increase(counts, numbers[number]);
                        break;
                    case 2:
                        if (numbers.ContainsKey(number))
                        {
                            Decrease(counts, numbers[number]);
                        }
                        Decrease(numbers, number);
                        if (numbers.ContainsKey(number))
                        {
                            Increase(counts, numbers[number]);
                        }
                        break;
                    case 3:
                        results.Add(CheckIfFrequencyPresent(counts, number) ? 1 : 0);
                        break;
                    default:
                        throw new NotSupportedException($"Operation with code: {operation} is not supported.");
                }
            }

            return results;
        }
    }
}

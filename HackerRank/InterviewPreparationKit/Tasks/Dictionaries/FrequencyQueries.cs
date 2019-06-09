using System;
using System.Collections.Generic;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Problem: <see href="https://www.hackerrank.com/challenges/frequency-queries/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Frequency Queries</see>.
    /// </Summary>
    public class FrequencyQueries
    {
        private static void HandleAdd(Dictionary<int, int> numbers, int num)
        {
            if (numbers.ContainsKey(num))
            {
                numbers[num]++;
            }
            else
            {
                numbers[num] = 1;
            }
        }

        private static void HandleRemove(Dictionary<int, int> numbers, int num)
        {
            if (numbers.ContainsKey(num) && numbers[num] > 0)
            {
                numbers[num]--;
            }
        }

        private static bool CheckIfFrequencyPresent(Dictionary<int, int> numbers, int frequency)
        {
            foreach (var item in numbers)
            {
                if (item.Value == frequency)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<int> FreqQuery(List<List<int>> queries)
        {
            var numbers = new Dictionary<int, int>();
            var results = new List<int>();

            foreach (var query in queries)
            {
                switch (query[0])
                {
                    case 1:
                        HandleAdd(numbers, query[1]);
                        break;
                    case 2:
                        HandleRemove(numbers, query[1]);
                        break;
                    case 3:
                        results.Add(CheckIfFrequencyPresent(numbers, query[1]) ? 1 : 0);
                        break;
                    default:
                        throw new NotSupportedException($"Operation with code: {query[0]} is not supported.");
                }
            }

            return results;
        }
    }
}

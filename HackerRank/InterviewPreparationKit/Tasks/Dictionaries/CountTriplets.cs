using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/count-triplets-1/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Count Triplets</see> problem.
    /// </Summary>
    public class CountTriplets
    {
        private static readonly long BASE_ONE = 1;

        private static bool IsPowerOf(long num, long r)
        {
            if (num == 0)
            {
                return false;
            }

            if (r == BASE_ONE)
            {
                return num == 1;
            }

            long result = 1;
            while (result < num)
            {
                result = result * r;
            }

            return result == num;
        }

        private static Dictionary<long, List<int>> IndexPowersOf(List<long> arr, long r)
        {
            var powers = new Dictionary<long, List<int>>();

            for (int i = 0; i < arr.Count; i++)
            {
                long value = arr[i];
                List<int> indexes = null;
                if (!powers.TryGetValue(value, out indexes))
                {
                    indexes = new List<int>();
                    powers[value] = indexes;
                }

                indexes.Add(i);
            }

            return powers;
        }

        public static long Count(List<long> arr, long r)
        {
            int triplets = 0;
            List<long> filtered = arr.Where(num => IsPowerOf(num, r)).ToList();
            var powers = IndexPowersOf(filtered, r);

            for (int idx = 0; idx <= filtered.Count - 3; idx++)
            {
                long first = filtered[idx];

                long second = first * r;
                List<int> secondIndexes = null;
                if (!powers.TryGetValue(second, out secondIndexes))
                {
                    continue;
                }

                foreach (int secIdx in secondIndexes.Where(secIdx => secIdx > idx))
                {
                    long third = second * r;
                    List<int> thirdIndexes = null;
                    if (!powers.TryGetValue(third, out thirdIndexes))
                    {
                        break;
                    }

                    triplets += thirdIndexes.Where(thirdIdx => thirdIdx > secIdx).Count();
                }
            }

            return triplets;
        }
    }
}
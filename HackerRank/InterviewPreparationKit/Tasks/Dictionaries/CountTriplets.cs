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

        private static readonly long MAX_NUMBER = 1000000000;

        private static bool IsPowerOf(long num, long r)
        {
            if (num == 0)
            {
                return false;
            }

            int pow = 0;
            double result = 0;
            while ((result = Math.Pow(r, pow)) < num)
            {
                pow++;
            }

            return result == num;
        }

        private static Dictionary<long, List<int>> IndexPowersOf(List<long> arr, long r)
        {
            var powers = new Dictionary<long, List<int>>();

            for (int i = 0; i < arr.Count; i++)
            {
                long value = arr[i];
                if (IsPowerOf(value, r))
                {
                    List<int> numbers = null;
                    if (!powers.TryGetValue(value, out numbers))
                    {
                        numbers = new List<int>();
                        powers[value] = numbers;
                    }

                    numbers.Add(i);
                }
            }

            return powers;
        }

        public static long Count(List<long> arr, long r)
        {
            if (r == BASE_ONE)
            {
                return 0;
            }

            int triplets = 0;
            var powers = IndexPowersOf(arr, r);

            for (int idx = 0; idx <= arr.Count - 3; idx++)
            {
                long first = arr[idx];
                if (!IsPowerOf(first, r))
                {
                    continue;
                }

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
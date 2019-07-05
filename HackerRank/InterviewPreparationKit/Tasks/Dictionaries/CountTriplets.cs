using System;
using System.Collections.Generic;
using System.Linq;
using Triplet = System.Collections.Generic.List<long>;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/count-triplets-1/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Count Triplets</see> problem.
    /// </Summary>
    public class CountTriplets
    {
        public static long Count(List<long> arr, long r)
        {
            long tripletsCount = 0;
            var stage2 = new Dictionary<long, long>();
            var stage3 = new Dictionary<long, long>();

            for(int idx = 0; idx < arr.Count; idx++)
            {
                long value = arr[idx];

                if (value == 0)
                {
                    continue;
                }

                long nextValue = value * r;
                if (stage3.ContainsKey(value))
                {
                    tripletsCount += stage3[value];
                }

                if (stage2.ContainsKey(value))
                {
                    if (!stage3.ContainsKey(nextValue))
                    {
                        stage3.Add(nextValue, 0);
                    }

                    stage3[nextValue] += stage2[value];
                }

                if (!stage2.ContainsKey(nextValue))
                {
                    stage2.Add(nextValue, 0);
                }
                stage2[nextValue]++;
            }

            return tripletsCount;
        }
    }
}
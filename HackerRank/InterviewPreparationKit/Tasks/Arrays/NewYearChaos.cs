using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Arrays
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays">New Year Chaos</see>.
    /// </Summary>
    public class NewYearChaos
    {
        private static void Move(int[] arr, int idx, int steps)
        {
            for (var i = 0; i < steps; i++)
            {
                var cur = arr[idx + i];
                arr[idx + i] = arr[idx + i + 1];
                arr[idx + i + 1] = cur;
            }
        }

        public static int MinimumBribes(int[] q)
        {
            int bribes = 0;
            for (var i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] == (i + 1)) { continue; }

                int idx = Array.IndexOf(q, i + 1, Math.Max(i - 2, 0));

                if (idx == -1) { return -1; }

                int diff = i - idx;

                Move(q, idx, diff);
                bribes += diff;
            }
            return bribes;
        }
    }
}

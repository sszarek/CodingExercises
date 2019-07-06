using System;

namespace InterviewPreparationKit.Tasks.Recursion
{
    /// <Summary>
    /// Solution for <See href="https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking">Davi's Staircase</See> problem.
    /// </Summary>
    public class DavisStaircase
    {
        public static int StepsPerm(int n)
        {
            int[] cache = new int[n + 1];
            Array.Fill(cache, -1);

            return StepsPerm(n, cache);
        }

        public static int StepsPerm(int n, int[] cache)
        {
            if (n < 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return 1;
            }

            if (cache[n] != -1)
            {
                return cache[n];
            }

            cache[n] = StepsPerm(n - 1, cache) + StepsPerm(n - 2, cache) + StepsPerm(n - 3, cache);
            return cache[n];
        }
    }
}
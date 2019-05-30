using System;

namespace InterviewPreparationKit.Tasks.Arrays
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays">Minimum Swaps 2</see> problem.
    /// </Summary>
    public class MinimumSwaps
    {
        private static void Swap(int[] arr, int idxA, int idxB)
        {
            int valA = arr[idxA];
            arr[idxA] = arr[idxB];
            arr[idxB] = valA;
        }

        public static int CalculateMinimumSwaps(int[] arr)
        {
            int swaps = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == (i + 1)) continue;
                
                Swap(arr, i, arr[i] - 1);
                swaps++;
            }


            return swaps;
        }
    }
}
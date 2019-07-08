using System;

namespace InterviewPreparationKit.Tasks.Greedy
{
    public class MinimumAbsoluteDiff
    {
        public static int MinimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);
            int minimumDiff = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i + 1]);
                if (diff < minimumDiff)
                {
                    minimumDiff = diff;
                }

            }
            return minimumDiff;
        }
    }
}
using System;

namespace InterviewPreparationKit.Tasks.Greedy
{
    public class MinimumAbsoluteDiff
    {
        public static int MinimumAbsoluteDifference(int[] arr)
        {
            int minimumDiff = int.MaxValue;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    int diff = Math.Abs(arr[i] - arr[j]);
                    if (diff < minimumDiff)
                    {
                        minimumDiff = diff;
                    }
                }
            }
            return minimumDiff;
        }
    }
}
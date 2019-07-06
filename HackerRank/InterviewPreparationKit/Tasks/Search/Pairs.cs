using System;

namespace InterviewPreparationKit.Tasks.Search
{
    public class Pairs
    {
        public static int CountPairs(int k, int[] arr)
        {
            int count = 0;
            Array.Sort(arr);

            for (int idx = 0; idx < arr.Length; idx++)
            {
                int value = arr[idx];
                int second = k + value;

                int secondIdx = Array.BinarySearch(arr, idx + 1, arr.Length - idx - 1, second);
                if (secondIdx > -1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
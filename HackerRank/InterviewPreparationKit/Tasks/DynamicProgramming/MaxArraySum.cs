using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.DynamicProgramming
{
    public class MaxArraySum
    {
        public static int MaxSubsetSum(int[] arr)
        {
            int max = int.MinValue;
            int[] cache = new int[arr.Length];
            Array.Fill(cache, int.MinValue);

            for(int idx = 0; idx < arr.Length - 2; idx++)
            {
                if (cache[idx] == int.MinValue)
                {
                    cache[idx] = arr[idx] + CalculateSum(arr, idx, cache);
                }

                max = Math.Max(max, Math.Max(cache[idx], arr[idx]));
            }

            return max;
        }

        private static int CalculateSum(int[] arr, int curIdx, int[] cache)
        {
            if(curIdx >= (arr.Length - 2))
            {
                return 0;
            }

            int max = int.MinValue;
            for(int idx = curIdx + 2; idx < arr.Length; idx++)
            {
                if (cache[idx] == int.MinValue)
                {
                    cache[idx] = arr[idx] + CalculateSum(arr, idx, cache);
                }  

                max = Math.Max(max, Math.Max(cache[idx], arr[idx]));
            }

            return max;
        }
    }
}
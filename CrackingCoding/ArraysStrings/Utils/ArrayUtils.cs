using System;

namespace ArraysStrings.Utils
{
    public static class ArrayUtils
    {
        public static T[] ShiftRight<T>(this T[] arr, int start, int delta)
        {
            if (delta == 0) {
                return arr;
            }

            var startIdx = arr.Length - 1 + delta;
            var endIdx = start + delta;

            for (var i = startIdx; i >= endIdx; i--)
            {
                if (i < 0)
                {
                    arr[i] = default(T);
                    continue;
                }

                if (i >= arr.Length)
                {
                    arr[i - delta] = default(T);
                    continue;
                }

                arr[i] = arr[i - delta];
                arr[i - delta] = default(T);
            }
            return arr;
        }
    }
}

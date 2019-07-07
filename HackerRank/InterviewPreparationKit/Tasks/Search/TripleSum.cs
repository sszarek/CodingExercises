using System;

namespace InterviewPreparationKit.Tasks.Search
{
    public class TripleSum
    {
        public static long Triplets(int[] a, int[] b, int[] c)
        {
            Array.Sort(a);
            Array.Sort(c);

            long triplets = 0;
            int previous = -1;

            for (int idx = 0; idx < b.Length; idx++)
            {
                int value = b[idx];
                if (value == previous)
                {
                    continue;
                }
                else
                {
                    previous = value;
                }

                int aCnt = CountLowerValues(a, value);
                int cCnt = CountLowerValues(c, value);
                
                if (aCnt == 0 || cCnt == 0)
                {
                    continue;
                }

                triplets += (aCnt * cCnt);

            }

            return triplets;
        }

        private static int CountLowerValues(int[] arr, int value)
        {
            int idx = Array.BinarySearch(arr, value);
            if (idx < 0)
            {
                return ~idx;
            }

            return idx + 1;
        }
    }
}
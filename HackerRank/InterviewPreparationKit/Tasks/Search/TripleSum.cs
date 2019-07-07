using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Search
{
    public class TripleSum
    {
        public static long Triplets(int[] a, int[] b, int[] c)
        {
            int[] aSorted = a.Distinct().OrderBy(val => val).ToArray();
            int[] bUnique = b.Distinct().ToArray();
            int[] cSorted = c.Distinct().OrderBy(val => val).ToArray();

            long triplets = 0;
            int previous = -1;

            for (int idx = 0; idx < bUnique.Length; idx++)
            {
                int value = bUnique[idx];
                if (value == previous)
                {
                    continue;
                }
                else
                {
                    previous = value;
                }

                int aCnt = CountLowerValues(aSorted, value);
                int cCnt = CountLowerValues(cSorted, value);
                
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
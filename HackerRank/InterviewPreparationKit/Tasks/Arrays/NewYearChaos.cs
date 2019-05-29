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
            for(var i = 0; i < steps; i++)
            {
                var cur = arr[idx + i];
                arr[idx + i] = arr[idx + i + 1];
                arr[idx + i + 1] = cur;  
            }
        } 

        public static int MinimumBribes(int[] q)
        {
            int bribes = 0;
            for (var i = 0; i < q.Length; i++)
            {
                int diff = q[i] - (i + 1);
                if (diff == 0) continue;
                if (diff > 2) return -1;

                if (diff > 0)
                {
                    Move(q, i, diff);
                    bribes += diff;
                    i--;
                }
            }
            return bribes;
        }
    }
}

/*
1, 2, 5, 3, 7, 8, 6, 4
-------
1,2,5,3,7,6,4,8 - 2
1,2,5,3,6,4,7,8 - 2
1,2,5,3,4,6,7,8 - 1
1,2,3,4,5,6,7,8 - 2


 */
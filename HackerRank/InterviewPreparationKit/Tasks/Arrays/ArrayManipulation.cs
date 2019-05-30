namespace InterviewPreparationKit.Tasks.Arrays
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays">Array Manpulation</see> problem.
    /// </Summary>
    public class ArrayManipulation
    {
        public static long Manipulate(int n, int[][] queries)
        {
            long[] initial = new long[n];
            long max = 0;

            for (var i = 0; i < queries.Length; i++)
            {
                var start = queries[i][0] - 1;
                var stop = queries[i][1] - 1;
                var number = queries[i][2];

                for (var j = start; j <= stop; j++)
                {
                    initial[j] += number;

                    if (initial[j] > max) max = initial[j];
                }
            }

            return max;

        }
    }
}
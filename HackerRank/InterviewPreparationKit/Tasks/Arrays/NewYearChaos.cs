using System.Linq;

namespace InterviewPreparationKit.Tasks.Arrays
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays">New Year Chaos</see>.
    /// </Summary>
    public class NewYearChaos
    {
        public static int MinimumBribes(int[] q)
        {
            int bribes = 0;
            for (var i = 0; i < q.Length; i++)
            {
                int diff = q[i] - (i + 1);
                if (diff > 0)
                {
                    bribes += diff;
                }
            }
            return bribes;
        }
    }
}
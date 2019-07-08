using System.Linq;

namespace InterviewPreparationKit.Tasks.Greedy
{
    public class LuckBalance
    {
        /// <Summary>
        /// Solution to <See href="https://www.hackerrank.com/challenges/luck-balance/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms">Luck Balance</See> problem.
        /// </Summary>
        public static int CalculateLuckBalance(int k, int[][] contests)
        {
            var important = contests
                .Where(c => c[1] == 1)
                .OrderByDescending(c => c[0]).ToArray();
            var importantSum = important.Take(k).Sum(c => c[0]) - important.Skip(k).Sum(c => c[0]);
            var notImportantSum = contests.Where(c => c[1] == 0).Sum(c => c[0]);

            return importantSum + notImportantSum;
        }
    }
}
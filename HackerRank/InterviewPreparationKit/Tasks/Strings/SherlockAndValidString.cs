namespace InterviewPreparationKit.Tasks.Strings
{
    /// <Summary>
    /// Problem: <see href="https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings">Sherlock and the valid String</see>.
    /// </Summary>
    public class SherlockAndValidString
    {
        private static readonly int CHAR_RANGE_START = 'a';

        private static int NormalizeCharIndex(char ch)
        {
            return ch - CHAR_RANGE_START;
        }

        public static bool IsValid(string s)
        {
            var letters = new int[26];
            var distinctChars = 0;
            foreach (char ch in s)
            {
                if (letters[NormalizeCharIndex(ch)] == 0)
                {
                    distinctChars++;
                }
                letters[NormalizeCharIndex(ch)]++;
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int distinctMins = 0;
            int distinctMaxes = 0;

            foreach (var count in letters)
            {
                if (min == count)
                {
                    distinctMins++;
                }

                if (count > 0 && min > count)
                {
                    min = count;
                    distinctMins = 1;
                }

                if (max == count)
                {
                    distinctMaxes++;
                }

                if (max < count)
                {
                    max = count;
                    distinctMaxes = 1;
                }
            }

            return (min == max) ||
                (distinctMaxes == 1 && min == max - 1) ||
                (distinctMins == 1 && min == 1 && distinctChars - 1 == distinctMaxes);
        }
    }
}

/*

a bb ccc ddd 1 vs 2

a bb

 */

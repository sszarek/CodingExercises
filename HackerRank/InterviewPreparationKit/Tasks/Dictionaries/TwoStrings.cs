using System.Linq;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/two-strings/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Two strings</see> problem.
    /// <Summary>
    public class TwoStrings
    {
        private static readonly int CHAR_RANGE_START = 97;

        private static bool[] MarkCharacterPresence(string s1)
        {
            // Input string s1 will contain ASCII chars from range a-z
            var chars = new bool[26];

            foreach (char ch in s1)
            {
                // char 'a' has value 97 according to ASCII table
                chars[ch - CHAR_RANGE_START] = true;
            }

            return chars;
        }

        public static bool IsSharingSubstring(string s1, string s2)
        {
            bool[] chars = MarkCharacterPresence(s1);

            foreach (char ch in s2)
            {
                if (chars[ch - CHAR_RANGE_START])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
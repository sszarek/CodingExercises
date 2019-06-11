namespace InterviewPreparationKit.Tasks.Strings
{
    /// <Summary>
    /// Problem <see href="https://www.hackerrank.com/challenges/special-palindrome-again/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings">Special String Again</see>.
    /// </Summary>
    public class SpecialStringAgain
    {
        public static long SubstringCount(string s)
        {
            long substrings = 0;

            for (var idx = 0; idx < s.Length; idx++)
            {
                substrings++;
                for (var endIdx = idx + 1; endIdx < s.Length; endIdx++)
                {
                    char prev = s[endIdx - 1];
                    char cur = s[endIdx];
                    if (prev == cur)
                    {
                        substrings++;
                        continue;
                    }

                    // last index, stop iteration
                    if (endIdx == s.Length - 1)
                    {
                        break;
                    }

                    // previous item is different than next one 
                    if (prev != s[endIdx + 1])
                    {
                        break;
                    }

                    int firstSegment = endIdx - idx;
                    for (var segmentIdx = endIdx + 1; segmentIdx < s.Length; segmentIdx++)
                    {
                        if (s[segmentIdx] != prev)
                        {
                            break;
                        }

                        if (segmentIdx - endIdx == firstSegment)
                        {
                            substrings++;
                            break;
                        }
                    }
    
                    break;
                }
            }

            return substrings;
        }
    }
}
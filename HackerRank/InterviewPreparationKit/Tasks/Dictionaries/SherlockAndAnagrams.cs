using System;
using System.Collections.Generic;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps">Sherlock and Anagrams</see> problem.
    /// </Summary>
    public class SherlockAndAnagrams
    {
        private static readonly int CHAR_RANGE_START = 97;

        private static int NormalizeCharCode(char ch)
        {
            return ch - CHAR_RANGE_START;
        }

        private static int[] CountDistinctChars(string str)
        {
            var chars = new int[26];

            foreach (var ch in str)
            {
                chars[NormalizeCharCode(ch)]++;
            }

            return chars;
        }

        public static bool IsAnagram(int[] s1, int[] s2)
        {
            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountAnagrams(string s)
        {
            int anagrams = 0;

            for (int length = 1; length < s.Length; length++)
            {
                for (int startIdx = 0; startIdx < s.Length - length; startIdx++)
                {
                    int[] firstSegment = CountDistinctChars(s.Substring(startIdx, length));
                    int[] secondSegment = CountDistinctChars(s.Substring(startIdx, length));

                    for (int windowPos = startIdx + 1; windowPos <= s.Length - length; windowPos++)
                    {
                        secondSegment[NormalizeCharCode(s[windowPos - 1])]--;
                        secondSegment[NormalizeCharCode(s[windowPos + length - 1])]++;

                        if (IsAnagram(firstSegment, secondSegment))
                        {
                            anagrams++;
                            Console.WriteLine($"Anagram++: {anagrams}");
                        }
                    }
                }
            }

            return anagrams;
        }
    }
}

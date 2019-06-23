using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Strings
{
    public class CommonChild
    {
        private static int CalculateChildLength(string s1, List<int>[] s2Index, int s1Idx, int s2Idx)
        {
            int lastFoundIndex = s2Idx;
            int childLength = 1;

            for (var childIdx = s1Idx + 1; childIdx < s1.Length; childIdx++)
            {
                char curChar = s1[childIdx];
                List<int> charIndexes = s2Index[curChar - 'A'];
                if (charIndexes == null)
                {
                    continue;
                }

                IEnumerable<int> acceptableIndexes = charIndexes.Where(idx => idx > lastFoundIndex);
                if (acceptableIndexes.Count() == 0)
                {
                    continue;
                }
                lastFoundIndex = acceptableIndexes.First();
                childLength++;
            }

            return childLength;
        }

        private static List<int>[] IndexString(string s)
        {
            var chars = new List<int>[26];
            for (var idx = 0; idx < s.Length; idx++)
            {
                char ch = s[idx];
                int charIdx = ch - 'A';
                if (chars[charIdx] == null)
                {
                    chars[charIdx] = new List<int>();
                }
                chars[charIdx].Add(idx);
            }

            return chars;
        }

        public static int CalculateLongestChildLength(string s1, string s2)
        {
            List<int>[] str2Index = IndexString(s2);
            int longestChild = int.MinValue;
            for (int s1Idx = 0; s1Idx < s1.Length; s1Idx++)
            {
                char s1Char = s1[s1Idx];
                List<int> indexes = str2Index[s1Char - 'A'];

                if (indexes == null)
                {
                    continue;
                }

                int s2CharImdex = indexes.First();
                int childLength = CalculateChildLength(s1, str2Index, s1Idx, s2CharImdex);

                if (longestChild < childLength)
                {
                    longestChild = childLength;
                }
            }

            return longestChild < -1 ? 0 : longestChild;
        }
    }
}
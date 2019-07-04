using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Strings
{
    /// <Summary>
    /// Solution to <See href="https://www.hackerrank.com/challenges/common-child/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings">Common Child</See> problem. 
    /// Theoretical background for this solution: <See href="https://en.wikipedia.org/wiki/Longest_common_subsequence_problem">Longest Common Subsequence Problem</See>.
    /// <Summary>
    public class CommonChild
    {
        public static int CalculateLongestChildLength(string s1, string s2)
        {
            var solutions = new int[s1.Length + 1, s2.Length + 1];

            for (var idx = 0; idx < s1.Length; idx++)
            {
                solutions[0, idx] = 0;
            }

            for (var idx = 0; idx < s2.Length; idx++)
            {
                solutions[idx, 0] = 0;
            }

            for (var row = 1; row <= s1.Length; row++)
            {
                for (var col = 1; col <= s2.Length; col++)
                {
                    if (s1[row - 1] == s2[col - 1])
                    {
                        solutions[row, col] = solutions[row - 1, col - 1] + 1;
                    }
                    else
                    {
                        var previousRow = solutions[row - 1, col];
                        var previousCol = solutions[row, col - 1];
                        
                        solutions[row,col] = Math.Max(previousRow, previousCol);
                    }
                }
            }

            return solutions[s1.Length, s2.Length];
        }
    }
}
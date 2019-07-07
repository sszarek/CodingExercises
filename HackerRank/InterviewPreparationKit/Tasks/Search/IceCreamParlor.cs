using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Search
{
    public class IceCreamParlor
    {
        /// <Summary>
        /// Solution for <See href="https://www.hackerrank.com/challenges/ctci-ice-cream-parlor/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=search">IceCream Parlor</See>
        /// </Summary>
        public static string WhatFlavors(int[] cost, int money)
        {
            var indexes = IndexNumbers(cost);

            int firstIdx = -1;
            int secondIdx = -1;
            for (int idx = 0; idx < cost.Length; idx++)
            {
                int value = cost[idx];
                int second = money - value;
                if (second < 0)
                {
                    continue;
                }

                if (indexes.ContainsKey(second))
                {
                    var potential = GetIndex(indexes[second], idx);
                    if (potential == -1)
                    {
                        continue;
                    }

                    firstIdx = idx;
                    secondIdx = potential;
                    
                    break;
                }
            }

            return String.Format("{0} {1}", Math.Min(firstIdx, secondIdx) + 1, Math.Max(firstIdx, secondIdx) + 1);
        }

        private static Dictionary<int, List<int>> IndexNumbers(int[] cost)
        {
            var indexes = new Dictionary<int, List<int>>();
            for(int idx = 0; idx < cost.Length; idx++)
            {
                var value = cost[idx];
                if (!indexes.ContainsKey(value))
                {   
                    indexes.Add(value, new List<int> {
                        idx
                    });
                }
                else
                {
                    indexes[value].Add(idx);
                }
            }

            return indexes;
        }
        
        private static int GetIndex(List<int> indexes, int omitIdx)
        {
            if(indexes.Count == 1 && indexes[0] == omitIdx)
            {
                return -1;
            }

            return indexes.FirstOrDefault(i => i > omitIdx);
        }
    }
}
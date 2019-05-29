using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Arrays
{
    /// <Summary>
    /// Solution to <see href="https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays">Hourglass problem</see>
    /// </Summary>
    public class Hourglass
    {

        private static int CalculateSum(int[][] arr, int row, int col)
        {
            var first = arr[row].Skip(col).Take(3).Sum();
            var last = arr[row + 2].Skip(col).Take(3).Sum();

            return first + last + arr[row + 1][col + 1];
        }

        public static int HourglassSum(int[][] arr)
        {
            var max = int.MinValue;

            for (var row = 0; row < 4; row++)
            {
                for (var col = 0; col < 4; col++)
                {
                    var sum = CalculateSum(arr, row, col);

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }


            return max;
        }
    }
}
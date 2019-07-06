using System;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Recursion
{
    public class RecursiveDigitSum
    {
        public static int SuperDigit(string n, int k)
        {
            long sum = n.Select(ch => (long)char.GetNumericValue(ch)).Sum();
            return (int)SuperDigit((sum * k).ToString());
        }

        public static long SuperDigit(string n)
        {
            long sum = n.Select(ch => (long)char.GetNumericValue(ch)).Sum();
            if (sum >= 10)
            {
                return SuperDigit(sum.ToString());
            }

            return sum;
        }
    }
}
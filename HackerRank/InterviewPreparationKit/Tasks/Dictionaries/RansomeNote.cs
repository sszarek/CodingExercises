using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit.Tasks.Dictionaries
{
    public class RansomeNote
    {
        public static bool CheckMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> dict = magazine
                .GroupBy(word => word)
                .ToDictionary(group => group.Key, group => group.Count());

            foreach (var word in note)
            {
                int count;
                if (dict.TryGetValue(word, out count) && count > 0)
                {
                    dict[word]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
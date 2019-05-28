using ArraysStrings.Utils;

namespace ArraysStrings.Tasks
{
    public static class URLify
    {
        private static void InsertEncodedSpace(char[] arr, int idx)
        {
            arr[idx] = '%';
            arr[idx + 1] = '2';
            arr[idx + 2] = '0';
        }

        public static string EncodeUrl(string input)
        {
            char[] chars = input.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                if (char.IsWhiteSpace(chars[i]))
                {
                    chars.ShiftRight(i, 2);
                    InsertEncodedSpace(chars, i);
                }
            }

            return string.Join(string.Empty, chars);
        }
    }
}
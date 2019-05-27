namespace ArraysStrings.Tasks
{
    public static class URLify
    {
        public static string EncodeUrl(string input)
        {
            char[] chars = input.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                if (char.IsWhiteSpace(chars[i]))
                {
                    
                }
            }

            return "%20";
        }
    }
}
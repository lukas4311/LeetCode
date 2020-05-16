namespace LongestPalindromicSubstring
{
    public class Solutiuon
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 0)
                return string.Empty;

            string longestPalindrome = s[0].ToString();
            int palindromeIncrement;
            int superIncrement;

            for (int i = 1; i < s.Length - 1;)
            {
                superIncrement = 0;
                palindromeIncrement = 1;

                if (s[i - 1] == s[i])
                {
                    superIncrement = 0;

                    while (true)
                    {
                        palindromeIncrement++;

                        if (s[i - palindromeIncrement] != s[i + palindromeIncrement - 1])
                            break;
                    }
                }

                if (s[i - 1] == s[i + 1])
                {
                    superIncrement = 1;

                    while (true)
                    {
                        palindromeIncrement++;

                        if (s[i - palindromeIncrement] != s[i + palindromeIncrement])
                            break;
                    }
                }

                if ((palindromeIncrement - 1) * 2 + superIncrement > longestPalindrome.Length)
                    longestPalindrome = s.Substring(i - (palindromeIncrement - 1), (palindromeIncrement - 1) * 2 + superIncrement);

                i += palindromeIncrement;

                if (longestPalindrome.Length >= s.Length - i)
                    break;
            }

            return longestPalindrome;
        }
    }
}

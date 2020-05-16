using System;

namespace LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 0)
                return string.Empty;

            string longestPalindrome = s[0].ToString();
            int even;
            int odd;

            for (int i = 1; i < s.Length;)
            {
                even = 0;
                odd = 0;

                if (i + 1 < s.Length && s[i - 1] == s?[i + 1])
                {
                    odd++;

                    while (true)
                    {
                        odd++;

                        if (i - odd < 0 || i + odd >= s.Length || s[i - odd] != s[i + odd])
                        {
                            odd--;
                            break;
                        }
                    }
                }

                if (s[i - 1] == s[i])
                {
                    even++;

                    while (true)
                    {
                        even++;

                        if (i - even < 0 || i + even - 1 >= s.Length || s[i - even] != s[i + even - 1])
                        {
                            even--;
                            break;
                        }

                    }
                }

                if (even > odd)
                {
                    if (even * 2 > longestPalindrome.Length)
                        longestPalindrome = s.Substring(i - even, even * 2);
                }
                else
                {
                    if (odd * 2 + 1 > longestPalindrome.Length)
                        longestPalindrome = s.Substring(i - (odd), (odd) * 2 + 1);
                }

                i++;

                if (longestPalindrome.Length > s.Length - i)
                    break;
            }

            return longestPalindrome;
        }
    }
}

using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime;
using System;

namespace LongestPalindromicSubstring
{
    [MemoryDiagnoser]
    public class Solution
    {
        [Benchmark(Baseline = true)]
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 0)
                return string.Empty;

            int startIndex = 0;
            int lenghtToEnd = 1;
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
                    if (even * 2 > lenghtToEnd)
                    {
                        startIndex = i - even;
                        lenghtToEnd = even * 2;
                    }
                }
                else
                {
                    if (odd * 2 + 1 > lenghtToEnd)
                    {
                        startIndex = i - odd;
                        lenghtToEnd = odd *2 + 1;
                    }
                }

                i++;

                if (lenghtToEnd / 2 > s.Length - i + 1)
                    break;
            }

            return s.Substring(startIndex, lenghtToEnd);
        }
    }
}

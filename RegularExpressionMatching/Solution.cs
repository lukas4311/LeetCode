using System.Net.Security;

namespace RegularExpressionMatching
{
    public class Solution
    {
        private const char Asterix = '*';
        private const char Dot = '.';

        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
            {
                return false;
            }

            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == Asterix && dp[0, i - 1])
                {
                    dp[0, i + 1] = true;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == Dot)
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    if (p[j] == s[i])
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    if (p[j] == Asterix)
                    {
                        if (p[j - 1] != s[i] && p[j - 1] != Dot)
                        {
                            dp[i + 1, j + 1] = dp[i + 1, j - 1];
                        }
                        else
                        {
                            dp[i + 1, j + 1] = (dp[i + 1, j] || dp[i, j + 1] || dp[i + 1, j - 1]);
                        }
                    }
                }
            }
            return dp[s.Length,p.Length];
        }
    }
}

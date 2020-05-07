using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] substringMaxLengthFromIndex = new int[s.Length];
            HashSet<char> usedChars = new HashSet<char>(substringMaxLengthFromIndex.Length);
            int totalMax = 0;

            for (int i = 0; i < substringMaxLengthFromIndex.Length - totalMax; i++)
            {
                substringMaxLengthFromIndex[i] = 0;

                for (int j = i; j < substringMaxLengthFromIndex.Length; j++)
                {
                    if (usedChars.Contains(s[j]))
                        break;

                    usedChars.Add(s[j]);
                    substringMaxLengthFromIndex[i]++;
                }

                if (substringMaxLengthFromIndex[i] > totalMax)
                    totalMax = substringMaxLengthFromIndex[i];

                usedChars.Clear();
            }

            return totalMax;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            int totalMax = 0;
            Dictionary<char, int> charsIndex = new Dictionary<char, int>();

            int i = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (charsIndex.ContainsKey(s[j]))
                {
                    if (charsIndex[s[j]] + 1 > i)
                    {
                        i = charsIndex[s[j]] + 1;
                    }

                    charsIndex[s[j]] = j;
                    totalMax = Math.Max(totalMax, j - i + 1);
                    continue;
                }

                totalMax = Math.Max(totalMax, j - i + 1);
                charsIndex.Add(s[j], j);
            }

            return totalMax;
        }
    }
}

using System.Linq;

namespace LongestCommonPrefix
{
    public class Solution
    {
        private const int EmptyArray = 0;
        private const int SingleElement = 1;

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == EmptyArray)
                return string.Empty;

            if (strs.Length == SingleElement)
                return strs[0];

            int shortesString = strs.Min(a => a.Length);
            string prefix = string.Empty;
            int sameCharacterPrefixCount = 0;
            char actualCharacter;
            bool isSame; 

            for (int i = 0; i < shortesString; i++)
            {
                actualCharacter = strs[0][i];
                isSame = true;

                for (int j = 1; j < strs.Length; j++)
                {
                    if (actualCharacter != strs[j][i])
                    {
                        isSame &= false;
                        break;
                    }
                }

                if (!isSame)
                    break;

                sameCharacterPrefixCount++;
            }

            return strs[0].Substring(0, sameCharacterPrefixCount);
        }
    }
}

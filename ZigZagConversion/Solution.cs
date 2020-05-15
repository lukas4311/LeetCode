using System.Text;

namespace ZigZagConversion
{
    public class Solution
    {
        private const int firstAndLastRowCount = 2;

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            int firstLettersCountToNextIndex;
            int secondLettersCountToNextIndex;
            bool useFirstIncrement;
            int j;
            int letterCountInOneSequence = numRows * 2 - firstAndLastRowCount;
            StringBuilder stringBuilder = new StringBuilder(s.Length);

            for (int i = 1; i <= numRows; i++)
            {
                j = i;

                if (j == 1 || j == numRows)
                {
                    while (j <= s.Length)
                    {
                        stringBuilder.Append(s[j - 1]);
                        j += letterCountInOneSequence;
                    }

                    continue;
                }

                firstLettersCountToNextIndex = (numRows - j) * 2;
                secondLettersCountToNextIndex = letterCountInOneSequence - firstLettersCountToNextIndex;
                useFirstIncrement = true;

                while (j <= s.Length)
                {
                    stringBuilder.Append(s[j - 1]);
                    j += useFirstIncrement ? firstLettersCountToNextIndex : secondLettersCountToNextIndex;
                    useFirstIncrement = !useFirstIncrement;
                }
            }

            return stringBuilder.ToString();
        }
    }
}

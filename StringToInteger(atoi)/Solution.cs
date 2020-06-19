using System.ComponentModel.Design;
using System.Text;

namespace StringToInteger_atoi_
{
    public class Solution
    {
        private const int AsciiCodeSpace = 32;
        private const int AsciiCodeNegative = 45;
        private const int AsciiCodeAdd = 43;
        private const int AsciiCodeZero = 48;
        private const int AsciiCodeNine = 57;

        public int MyAtoi(string str)
        {
            StringBuilder number = new StringBuilder(str.Length);
            int multiplier = 1;
            number.Append("0");
            bool digitStart = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= AsciiCodeZero && str[i] <= AsciiCodeNine)
                {
                    digitStart = true;
                    number.Append(str[i]);
                }
                else if (str[i] == AsciiCodeNegative)
                {
                    if (digitStart)
                        break;

                    if (i + 1 < str.Length && (str[i + 1] < AsciiCodeZero || str[i + 1] > AsciiCodeNine))
                    {
                        return 0;
                    }

                    multiplier = -1;
                }
                else if (str[i] == AsciiCodeAdd)
                {
                    if (digitStart)
                        break;

                    if (i + 1 < str.Length && (str[i + 1] < AsciiCodeZero || str[i + 1] > AsciiCodeNine))
                    {
                        return 0;
                    }

                    multiplier = 1;
                }
                else if (str[i] == AsciiCodeSpace)
                {
                    if (digitStart)
                        break;

                    continue;
                }
                else
                {
                    break;
                }
            }

            return int.TryParse(number.ToString(), out int parsedNumber) ? parsedNumber * multiplier : multiplier == 1 ? int.MaxValue : int.MinValue;
        }
    }
}

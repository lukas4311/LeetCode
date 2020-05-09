using System.Collections.Generic;
using System.Text;

namespace ZigZagConversion
{
    public class Solution
    {
        const int borderOfEmptyColumns = 3;

        public string Convert(string s, int numRows)
        {
            int specialColumns = numRows - 2;
            int columnDivident = s.Length;

            for (int i = 0; i < numRows + 1 - borderOfEmptyColumns; i++)
            {
                columnDivident += ((s.Length - specialColumns) / (numRows + i + 1) * numRows);
            }

            int allColumns = columnDivident / numRows;
            char[,] charMatrix = new char[numRows, allColumns];

            for (int j = 0; j < charMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < charMatrix.GetLength(0); i++)
                {
                    int actualStringIndex = j * (numRows - 1) + i;

                    if (actualStringIndex >= s.Length)
                        break;

                    if (j % (numRows - 1) == 0)
                    {
                        charMatrix[i, j] = s[actualStringIndex];
                    }
                    else
                    {
                        int reminder = j % (numRows - 1);

                        if (i == (numRows - 1 - reminder))
                        {
                            charMatrix[i, j] = s[actualStringIndex];
                            break;
                        }

                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int j = 0; j < charMatrix.GetLength(0); j++)
            {
                for (int i = 0; i < charMatrix.GetLength(1); i++)
                {
                    if (charMatrix[j, i] != default(char))
                        stringBuilder.Append(charMatrix[j, i]);
                }
            }

            return stringBuilder.ToString();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x > -10 && x < 10)
                return x;

            int multiplicator = 1;
            int result = 0;

            if(x < 0)
            {
                x *= -1;
                multiplicator = -1;
            }

            int newVal;

            while (x > 0)
            {
                newVal = result * 10 + x % 10;

                if (newVal / 10 == result)
                {
                    result = newVal;
                    x /= 10;
                }
                else
                {
                    return 0;
                }

            }

            return result * multiplicator;
        }
    }
}

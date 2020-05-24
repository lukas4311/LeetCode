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

            char[] number = x.ToString().Reverse().ToArray();

            if(int.TryParse(new string(number), out int parsedNumber)){
                return parsedNumber * multiplicator;
            }

            return result;
        }
    }
}

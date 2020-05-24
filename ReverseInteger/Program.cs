using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution reverse number");

            Solution solution = new Solution();
            int reversedNumber = solution.Reverse(2147483647);

            Console.WriteLine(reversedNumber);
        }
    }
}

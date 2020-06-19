using System;

namespace StringToInteger_atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String to Integer (atoi)!");
            Solution solution = new Solution();
            int number = solution.MyAtoi("+-2");
        }
    }
}

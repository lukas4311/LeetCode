using System;

namespace RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsMatch("ab", ".*"));
        }
    }
}

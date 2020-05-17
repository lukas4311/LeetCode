using BenchmarkDotNet.Running;
using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Solution solutiuon = new Solution();
            //solutiuon.LongestPalindrome("ababababababa");
            var summary = BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}

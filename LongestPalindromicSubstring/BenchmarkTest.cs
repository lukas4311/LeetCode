using BenchmarkDotNet.Attributes;

namespace LongestPalindromicSubstring
{
    
    public class BenchmarkTest
    {
        private const string _benchamrkInput = "372131289";
        private readonly Solution Solution;

        public BenchmarkTest()
        {
            this.Solution = new Solution();
        }

        [Benchmark]
        public string GetLongestPalidromicSubstring() => this.Solution.LongestPalindrome(_benchamrkInput);
    }
}

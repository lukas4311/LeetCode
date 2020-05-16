using LongestPalindromicSubstring;
using NUnit.Framework;

namespace SolutionTests
{
    [TestFixture]
    public class LongestPalindromicSubstringTest
    {
        private const string ReusltOddCase = "21312";
        private const string InputOddCase = "372131289";
        private const string ReusltEvenCase = "21312";
        private const string InputEvenCase = "372131289";
        private const string ResultAndInputOneLetterCase = "A";
        private const string ReusltFullPalindrome = "abba";
        private const string InputFullPalindrome = "abba";
        private const string InputFullPalindrome2 = "ccc";
        private const string InputPalidromeRightSide = "abb";
        private const string ResultPalidromeRightSide = "bb";
        private const string InputAndResultAllSameChar = "aaaa";

        [Test]
        public void TestLongestPlaindromeOdd()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputOddCase);
            //Assert
            Assert.AreEqual(result, ReusltOddCase);
        }

        [Test]
        public void TestLongestPlaindromeEven()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputEvenCase);
            //Assert
            Assert.AreEqual(result, ReusltEvenCase);
        }

        [Test]
        public void TestLongestPlaindromeOneLetter()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(ResultAndInputOneLetterCase);
            //Assert
            Assert.AreEqual(result, ResultAndInputOneLetterCase);
        }

        [Test]
        public void TestLongestPlaindromeEmptyString()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(string.Empty);
            //Assert
            Assert.AreEqual(result, string.Empty);
        }

        [Test]
        public void TestLongestPlaindromeFullPalindrome()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputFullPalindrome);
            //Assert
            Assert.AreEqual(result, ReusltFullPalindrome);
        }

        [Test]
        public void TestLongestPlaindromeFullPalindromeTwoChars()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome("bb");
            //Assert
            Assert.AreEqual(result, "bb");
        }

        [Test]
        public void TestLongestPlaindromeFullPalindrome2()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputFullPalindrome2);
            //Assert
            Assert.AreEqual(result, InputFullPalindrome2);
        }

        [Test]
        public void TestLongestPlaindromeRightSide()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputPalidromeRightSide);
            //Assert
            Assert.AreEqual(result, ResultPalidromeRightSide);
        }

        [Test]
        public void TestLongestPlaindromeMoreSameChars()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.LongestPalindrome(InputAndResultAllSameChar);
            //Assert
            Assert.AreEqual(result, InputAndResultAllSameChar);
        }
    }
}

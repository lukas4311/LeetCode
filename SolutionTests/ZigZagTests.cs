using NUnit.Framework;
using ZigZagConversion;

namespace SolutionTests
{
    [TestFixture]
    public class Tests
    {
        private const string PaypalIsHiringResult3Rows = "PAHNAPLSIIGYIR";
        private const string PaypalIsHiringResult4Rows = "PINALSIGYAHRPI";

        [Test]
        public void TestZigZag3Rows6Cols()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.Convert("PAYPALISHIRING", 3);
            //Assert
            Assert.AreEqual(result, PaypalIsHiringResult3Rows);
        }

        [Test]
        public void TestZigZagOneLetter()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.Convert("A", 3);
            //Assert
            Assert.AreEqual(result, "A");
        }

        [Test]
        public void TestZigZag2Rows()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.Convert("ABCDE", 2);
            //Assert
            Assert.AreEqual(result, "ACEBD");
        }

        [Test]
        public void TestZigZag1Row()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.Convert("ABCDE", 1);
            //Assert
            Assert.AreEqual(result, "ABCDE");
        }

        [Test]
        public void TestZigZag4RowsCols()
        {
            //Arrange
            //Act
            Solution solution = new Solution();
            string result = solution.Convert("PAYPALISHIRING", 4);
            //Assert
            Assert.AreEqual(result, PaypalIsHiringResult4Rows);
        }
    }
}
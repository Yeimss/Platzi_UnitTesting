using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;
namespace StringManipulation.Test
{
    public class StringOperationsTest
    {
        [Fact(Skip= "Esta prueba no es válida en este momento, TICKET-A01")]
        public void ConcatenateStrings()
        {
            var strOperation = new StringOperations();
            var result = strOperation.ConcatenateStrings("Hello", "Platzi");
            Assert.Equal("Hello Platzi", result);
        }
        [Fact]
        public void IsPalindrome_True()
        {
            var strOperation = new StringOperations();
            
            var result = strOperation.IsPalindrome("seres");

            Assert.True(result);
        }
        [Fact]
        public void IsPalindrome_False()
        {
            var strOperation = new StringOperations();

            var result = strOperation.IsPalindrome("Holiiii");

            Assert.False(result);
        }
        [Fact]
        public void QuantintyInWords()
        {
            var strOperation = new StringOperations();
            var result = strOperation.QuantintyInWords("dog", 2);
            Assert.StartsWith("dos", result);
            Assert.Contains ("dogs", result);
        }
        [Fact]
        public void GetStringLenght()
        {
            var strOperation = new StringOperations();

            var res = strOperation.GetStringLength("Aguacate");

            Assert.Equal(8, res);
        }
        [Fact]
        public void GetStringLenght_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => strOperation.GetStringLength(null));
        }
        [Fact]
        public void TruncateString_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperation.TruncateString("Chao pescado", -1));
        }
        [Theory]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("XX", 20)]
        [InlineData("L", 50)]
        [InlineData("XL", 40)]
        public void FromRomanToNumber(string roman, int expected)
        {
            var strOperation = new StringOperations();

            var res = strOperation.FromRomanToNumber(roman);

            Assert.Equal(expected, res);
        }
        [Theory]
        [InlineData("seres", true)]
        [InlineData("pegajoso", false)]
        [InlineData("oso", true)]
        [InlineData("murcielago", false)]
        [InlineData("ana", true)]
        public void IsPalindrome(string word, bool expected)
        {
            var strOperation = new StringOperations();

            var res  = strOperation.IsPalindrome(word);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("Oso moteado", "Osomoteado")]
        [InlineData("Oso pardo", "Osopardo")]
        [InlineData("Oso panda", "Osopanda")]
        [InlineData("Oso peresozo", "Osoperesozo")]
        public void RemoveWhitespace(string text, string expected)
        {
            var strOperation = new StringOperations();

            var res = strOperation.RemoveWhitespace(text);

            Assert.Equal(expected, res);
        }
        [Fact]
        public void CountOccurrences()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperation = new StringOperations(mockLogger.Object);

            var res = strOperation.CountOccurrences("texto prueba", 'e');

            Assert.Equal(2, res);
        }
        [Fact]
        public void ReadFile()
        {
            var strOperation = new StringOperations();
            var mockFile = new Mock<IFileReaderConector>();
            mockFile.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file");

            var res = strOperation.ReadFile(mockFile.Object, "file.txt");

            Assert.Equal("Reading file", res);
        }
    }
}

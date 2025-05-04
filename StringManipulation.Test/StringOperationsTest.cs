using Xunit;
namespace StringManipulation.Test
{
    public class StringOperationsTest
    {
        [Fact]
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
    }
}

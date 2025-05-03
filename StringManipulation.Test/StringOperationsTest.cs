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
    }
}

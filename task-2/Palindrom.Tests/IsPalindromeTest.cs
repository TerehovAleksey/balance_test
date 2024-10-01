namespace Palindrom.Tests
{
    public class IsPalindromeTest
    {
        [Fact]
        public void IsPalindrome_ReturnTrueCorrect()
        {
            // Arrange
            var number = 20200202;

            // Act
            var result = Logic.IsPalindrome(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ReturnFalseCorrect()
        {
            // Arrange
            var number = 10562;

            // Act
            var result = Logic.IsPalindrome(number);

            // Assert
            Assert.False(result);
        }
    }
}

namespace Palindrom.Tests
{
    public class IsKPalindromeTest
    {
        [Fact]
        public void IsKPalindrome_ReturnTrueCorrect()
        {
            // Arrange
            var number = 20200202;
            var k = 2;

            // Act
            var result = Logic.IsKPalindrome(number, k);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsKPalindrome_WithWrongK_ReturnFalseCorrect()
        {
            // Arrange
            var number = 20200202;
            var k = 3;

            // Act
            var result = Logic.IsKPalindrome(number, k);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsKPalindrome_WithWrongNumber_ReturnFalseCorrect()
        {
            // Arrange
            var number = 20200212;
            var k = 2;

            // Act
            var result = Logic.IsKPalindrome(number, k);

            // Assert
            Assert.False(result);
        }
    }
}

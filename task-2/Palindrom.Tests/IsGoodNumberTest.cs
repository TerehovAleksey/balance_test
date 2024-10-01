namespace Palindrom.Tests
{
    public class IsGoodNumberTest
    {
        [Fact]
        public void IsGoodNumber_ReturnTrueCorrect()
        {
            // Arrange
            var x = 2020;
            var k = 2;

            // Act
            var result = Logic.IsGoodNumber(x, k);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsGoodNumber_ReturnFalseCorrect()
        {
            // Arrange
            var x = 1010;
            var k = 2;

            // Act
            var result = Logic.IsGoodNumber(x, k);

            // Assert
            Assert.False(result);
        }
    }
}

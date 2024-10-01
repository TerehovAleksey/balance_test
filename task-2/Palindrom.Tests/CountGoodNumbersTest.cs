namespace Palindrom.Tests
{
    public class CountGoodNumbersTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var n = 3;
            var k = 5;

            // Act
            var count = Logic.CountGoodNumbers(n, k);

            // Assert
            Assert.Equal(27, count);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var n = 1;
            var k = 4;

            // Act
            var count = Logic.CountGoodNumbers(n, k);

            // Assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var n = 5;
            var k = 6;

            // Act
            var count = Logic.CountGoodNumbers(n, k);

            // Assert
            Assert.Equal(2468, count);
        }
    }
}
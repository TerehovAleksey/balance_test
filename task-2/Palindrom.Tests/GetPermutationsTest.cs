namespace Palindrom.Tests
{
    public class GetPermutationsTest
    {

        [Fact]
        public void GetPermutations_ReturnCorrect()
        {
            // Arrange
            var x = 2020;

            // Act
            var result = Logic.GetPermutations(x);

            // Assert
            Assert.True(result.Any());
        }

        [Fact]
        public void GetPermutations_LongNumber_ReturnCorrect()
        {
            // Arrange
            var x = 16854628;

            // Act
            var result = Logic.GetPermutations(x);

            // Assert
            Assert.True(result.Any());
        }
    }
}

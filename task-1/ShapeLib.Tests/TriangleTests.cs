using ShapeLib.Parameters;
using ShapeLib.Shapes;

namespace ShapeLib.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_WithValidSides_ReturnsCorrectArea()
    {
        // Arrange
        var triangleParams = new TriangleParameters(3, 4, 5);
        var triangle = new Triangle(triangleParams);

        // Act
        var area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area, precision: 5);
    }

    [Fact]
    public void CalculateArea_WithInvalidSides_ThrowsArgumentException()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new TriangleParameters(1, 2, 3));
    }

    [Fact]
    public void CalculateArea_WithZeroOrNegativeSides_ThrowsArgumentException()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new TriangleParameters(0, 4, 5));
        Assert.Throws<ArgumentException>(() => new TriangleParameters(-3, 4, 5));
    }
}
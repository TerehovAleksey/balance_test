using ShapeLib.Parameters;
using ShapeLib.Shapes;

namespace ShapeLib.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_WithValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        var circleParams = new CircleParameters(5);
        var circle = new Circle(circleParams);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 5 * 5, area, precision: 5);
    }
    
    [Fact]
    public void CalculateArea_WithZeroRadius_ReturnsZero()
    {
        // Arrange
        var circleParams = new CircleParameters(0);
        var circle = new Circle(circleParams);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(0, area);
    }

    [Fact]
    public void CalculateArea_WithNegativeRadius_ReturnsArea()
    {
        // Arrange
        var circleParams = new CircleParameters(-3);
        var circle = new Circle(circleParams);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * (-3) * (-3), area, precision: 5);
    }
}
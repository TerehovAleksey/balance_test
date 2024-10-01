using ShapeLib.Parameters;
using ShapeLib.Parameters.Base;
using ShapeLib.Shapes;

namespace ShapeLib.Tests;

public class ShapeFactoryTests
{
    [Fact]
    public void CreateShape_WithCircleParameters_ReturnsCircle()
    {
        // Arrange
        var circleParams = new CircleParameters(5);

        // Act
        var shape = ShapeFactory.CreateShape(circleParams);

        // Assert
        Assert.IsType<Circle>(shape);
    }

    [Fact]
    public void CreateShape_WithTriangleParameters_ReturnsTriangle()
    {
        // Arrange
        var triangleParams = new TriangleParameters(3, 4, 5);

        // Act
        var shape = ShapeFactory.CreateShape(triangleParams);

        // Assert
        Assert.IsType<Triangle>(shape);
    }
    
    private class NotImplementedParameters : ShapeParameters { }

    [Fact]
    public void CreateShape_WithInvalidParameters_ThrowsInvalidOperationException()
    {
        // Arrange
        var unknownParams = new NotImplementedParameters();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => ShapeFactory.CreateShape(unknownParams));
    }
}
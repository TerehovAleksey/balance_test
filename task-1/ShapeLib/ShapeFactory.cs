using ShapeLib.Parameters;
using ShapeLib.Parameters.Base;
using ShapeLib.Shapes;
using ShapeLib.Shapes.Base;

namespace ShapeLib;

public static class ShapeFactory
{
    public static Shape CreateShape(ShapeParameters parameters)
    {
        return parameters switch
        {
            CircleParameters circleParams => new Circle(circleParams),
            TriangleParameters triangleParams => new Triangle(triangleParams),
            _ => throw new InvalidOperationException()
        };
    }
}
using ShapeLib.Parameters;
using ShapeLib.Shapes.Base;

namespace ShapeLib.Shapes;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(CircleParameters parameters)
    {
        Radius = parameters.Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
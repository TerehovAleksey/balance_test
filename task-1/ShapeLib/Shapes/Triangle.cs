using ShapeLib.Parameters;
using ShapeLib.Shapes.Base;

namespace ShapeLib.Shapes;

public class Triangle : Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(TriangleParameters parameters)
    {
        SideA = parameters.SideA;
        SideB = parameters.SideB;
        SideC = parameters.SideC;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - SideA) *
                         (semiPerimeter - SideB) *
                         (semiPerimeter - SideC));
    }
}
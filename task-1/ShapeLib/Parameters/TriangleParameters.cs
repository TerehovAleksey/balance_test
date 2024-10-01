using ShapeLib.Parameters.Base;

namespace ShapeLib.Parameters;

public class TriangleParameters : ShapeParameters
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public TriangleParameters(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        if (!IsValidTriangle())
        {
            throw new ArgumentException("Стороны не могут образовать треугольник.");
        }
    }
    
    private bool IsValidTriangle()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }
}
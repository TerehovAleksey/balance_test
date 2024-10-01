using ShapeLib.Parameters.Base;

namespace ShapeLib.Parameters;

public class CircleParameters : ShapeParameters
{
    public double Radius { get; }

    public CircleParameters(double radius)
    {
        Radius = radius;
    }
}
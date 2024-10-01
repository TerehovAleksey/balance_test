using ShapeLib;
using ShapeLib.Parameters;
using ShapeLib.Parameters.Base;

Console.WriteLine("Выберите фигуру для расчета площади:");
Console.WriteLine("1. Круг");
Console.WriteLine("2. Треугольник");

var choice = Console.ReadLine();
ShapeParameters shapeParameters;
switch (choice)
{
    case "1":
        Console.Write("Введите радиус круга: ");
        var radius = Convert.ToDouble(Console.ReadLine());
        shapeParameters = new CircleParameters(radius);
        break;
    case "2":
        Console.Write("Введите длину первой стороны треугольника: ");
        var sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второй стороны треугольника: ");
        var sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину третьей стороны треугольника: ");
        var sideC = Convert.ToDouble(Console.ReadLine());
        shapeParameters = new TriangleParameters(sideA, sideB, sideC);
        break;
    default:
        throw new InvalidOperationException("Некорректный выбор фигуры.");
}

try
{
    var shape = ShapeFactory.CreateShape(shapeParameters);
    Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
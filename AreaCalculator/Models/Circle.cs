namespace AreaCalculator.Models;

/// <summary>
/// Класс для работы с кругами
/// </summary>
public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius is less than or equal to zero.");

        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
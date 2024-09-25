namespace Figures.Common;

public class Circle : IShape
{
    protected readonly double _radius;

    public Circle(double radius)
    {
        radius.ThrowIfNegativeInfinityOrZero("Радиус круга должен быть конечным и больше нуля.");
        _radius = radius;
    }

    public double CalculateArea()
        => Math.PI * _radius * _radius;
}
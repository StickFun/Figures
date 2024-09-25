namespace Figures.Common;

public class Triangle : IShape
{
    #region Fields: Private
    protected const string InvalidSideValueMessage = "Сторона треугольника должна быть конечной и больше нуля.";

    protected readonly double _firstSide;
    protected readonly double _secondSide;
    protected readonly double _thirdSide;
    protected readonly double _halfPerimeter;
    #endregion

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        firstSide.ThrowIfNegativeInfinityOrZero(InvalidSideValueMessage);
        secondSide.ThrowIfNegativeInfinityOrZero(InvalidSideValueMessage);
        thirdSide.ThrowIfNegativeInfinityOrZero(InvalidSideValueMessage);

        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;

        if (!IsTriangleExists())
        {
            throw new FigureException("При заданных сторонах треугольник не существует.");
        }

        _halfPerimeter = CalculateHalfPerimeter();
    }

    public double CalculateArea()
        => Math.Sqrt(_halfPerimeter * (_halfPerimeter - _firstSide) * (_halfPerimeter - _secondSide) * (_halfPerimeter - _thirdSide));

    public bool IsRightTriangle()
    {
        double[] sides = { _firstSide, _secondSide, _thirdSide };
        var orderedSides = sides.Order();

        return Math.Pow(orderedSides.ElementAt(2), 2) == Math.Pow(orderedSides.ElementAt(1), 2) + Math.Pow(orderedSides.ElementAt(0), 2);
    }

    protected double CalculateHalfPerimeter()
        => (_firstSide + _secondSide + _thirdSide) / 2;

    protected bool IsTriangleExists()
        => _firstSide <= _secondSide + _thirdSide
        && _secondSide <= _thirdSide + _firstSide
        && _thirdSide <= _firstSide + _secondSide;
}
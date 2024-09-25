using Figures.Common;

namespace Figures.Tests;

public class FiguresTests
{
    [Theory]
    [InlineData(5.0, 78.54)]
    [InlineData(29.0, 2642.0)]
    [InlineData(101.0, 32047.0)]
    [InlineData(13.2646, 552.8)]
    public void CalculateCircleAreaTest(double radius, double actualArea)
    {
        var circle = ShapeFactory.CreateCircle(radius);
        Assert.Equal(actualArea, circle.CalculateArea(), tolerance: 0.5);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5.3128, 125.2498, 124.489, 328.2)]
    [InlineData(0.000013, 0.000001, 0.0000125, 5.517e-12)]
    [InlineData(85328.2548, 93218.123498, 12384.529, 425075626)]
    public void CalculateTriangleAreaTest(double firstSide, double secondSide, double thirdSide, double actualArea)
    {
        var triangle = ShapeFactory.CreateTriangle(firstSide, secondSide, thirdSide);
        Assert.Equal(actualArea, triangle.CalculateArea(), tolerance: 1);
    }

    [Theory]
    [InlineData(5, 3, 4, true)]
    [InlineData(3, 5, 3, false)]
    [InlineData(10, 17, 9, false)]
    [InlineData(12384.529, 85328.2548, 93218.123498, false)]
    public void IsRightTriangleTest(double firstSide, double secondSide, double thirdSide, bool isRightTriangle)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        Assert.Equal(isRightTriangle, triangle.IsRightTriangle());
    }

    [Theory]
    [InlineData(5.0, double.NaN, 4.3)]
    public void IncorrectTriangleSidesTest(double firstSide, double secondSide, double thirdSide)
    {
        Assert.Throws<FigureException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Theory]
    [InlineData(-2.0)]
    [InlineData(0)]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void IncorrectCircleRadiusTest(double radius)
    {
        Assert.Throws<FigureException>(() => new Circle(radius));
    }
}
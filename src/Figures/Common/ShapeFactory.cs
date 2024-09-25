namespace Figures.Common;

public static class ShapeFactory
{
    public static IShape CreateTriangle(double firstSide, double secondSide, double thirdSide)
        => new Triangle(firstSide, secondSide, thirdSide);

    public static IShape CreateCircle(double radius)
        => new Circle(radius);
}

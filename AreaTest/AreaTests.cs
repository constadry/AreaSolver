using AreaSolver;

namespace AreaTest;

public class AreaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test] public void TrueTriangleArea()
    {
        const double expectedArea = 6;
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        Shape triangle = new Triangle(firstSide, secondSide, thirdSide);
        Assert.That(triangle.Area, Is.EqualTo(expectedArea));
    }

    [Test]
    public void NotExistingTriangle()
    {
        const double firstSide = 1;
        const double secondSide = 1;
        const double thirdSide = 2;
        Assert.Catch<ArgumentException>(() =>
        {
            Shape triangle = new Triangle(firstSide, secondSide, thirdSide);
        });
    }
    
    [Test]
    public void NegativeSides()
    {
        const double firstSide = -1;
        const double secondSide = 1;
        const double thirdSide = 2;
        Assert.Catch<ArgumentException>(() =>
        {
            Shape triangle = new Triangle(firstSide, secondSide, thirdSide);
        });
    }
    
    [Test] public void TrueCircleArea()
    {
        const double expectedArea = 113.04;
        const double radius = 6;
        Shape circle = new Circle(radius);
        var actualArea = circle.Area;
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.1d));
    }
}
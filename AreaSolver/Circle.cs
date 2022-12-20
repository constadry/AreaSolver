namespace AreaSolver;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        Validate();
    }

    protected override void Validate()
    {
        if (_radius <= 0)
            throw new ArgumentException("Radius should be positive");
    }

    public override double Area
    {
        get
        {
            Validate();
            return Math.PI * _radius * _radius;
        }
    }
}
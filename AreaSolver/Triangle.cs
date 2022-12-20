namespace AreaSolver;

public class Triangle : Shape
{
    private double _a;
    private double _b;
    private double _c;
    
    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
        Validate();
    }

    protected override void Validate()
    {
        if (_a > 0 && _b > 0 && _c > 0)
        {
            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                throw new ArgumentException("Triangle with these sides doesn't exist");
            }
        }
        else
        {
            throw new ArgumentException("Triangle with negative sides doesn't exist");
        }
    }

    public bool IsRight()
    {
        Validate();
        return _a * _a + _b * _b == _c * _c || _a * _a + _c * _c == _b * _b || _c * _c + _b * _b == _a * _a;
    }

    public override double Area
    {
        get
        {
            Validate();
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
namespace AreaSolver;

public abstract class Shape
{
    /// <summary>
    /// Checking correctness of entered values and math rules of existing shape
    /// </summary>
    protected abstract void Validate();
    
    /// <summary>
    /// Area of shape
    /// </summary>
    public abstract double Area { get; }
}
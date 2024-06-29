namespace Lib.ShapesFactory.Shapes;

public abstract class BaseShape : IShape
{
    public virtual double CalculateArea()
        => 0;
}

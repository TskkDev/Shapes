using Lib.ShapesFactory.Models;

namespace Lib.ShapesFactory.Shapes;

public sealed class Circle : BaseShape
{
    #region Fiels
    private CircleModel circleModel;
    #endregion

    # region Constructors
    public Circle(CircleModel model) 
    {
        circleModel = model;
    }
    #endregion

    #region Overrides
    public override double CalculateArea()
        => Math.PI * Math.Pow(circleModel.Radius, 2);
    #endregion
}

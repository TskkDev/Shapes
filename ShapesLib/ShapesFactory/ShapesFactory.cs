using Lib.ShapesFactory.Interfaces;
using Lib.ShapesFactory.Models;
using Lib.ShapesFactory.Shapes;

namespace Lib.ShapesFactory
{
    public sealed class ShapesFactory : IShapeFactory
    {
        public T CreateShape<T>(BaseShapeModel model) where T : IShape
        {
            if (typeof(T) == typeof(Circle))
            {
                return (T)(object)new Circle((CircleModel)model);
            }
            else if (typeof(T) == typeof(Triangle))
            {
                return (T)(object)new Triangle((TriangleModel)model);
            }
            else
            {
                throw new NotSupportedException("unsupported shape");
            }
        }
    }
}

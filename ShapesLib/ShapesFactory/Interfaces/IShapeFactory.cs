using Lib.ShapesFactory.Models;

namespace Lib.ShapesFactory.Interfaces
{
    public interface IShapeFactory
    {
        public T CreateShape<T>(BaseShapeModel model) where T : IShape;
    }
}

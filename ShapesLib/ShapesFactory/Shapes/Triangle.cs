using Lib.ShapesFactory.Models;

namespace Lib.ShapesFactory.Shapes
{
    public class Triangle : BaseShape
    {
        protected TriangleModel triangleModel;
        public Triangle(TriangleModel model)
        {
            triangleModel = model;
        }
        public override double CalculateArea()
        {
            var semiPerimeter = (triangleModel.SideA
                + triangleModel.SideB
                + triangleModel.SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - triangleModel.SideA)
                * (semiPerimeter - triangleModel.SideB) * (semiPerimeter - triangleModel.SideC));
        }
        public bool IsRightTriangle()
            => Math.Pow(triangleModel.SideA, 2) == Math.Pow(triangleModel.SideB, 2) + Math.Pow(triangleModel.SideC, 2)//best by perfomanse method i think
            || Math.Pow(triangleModel.SideB, 2) == Math.Pow(triangleModel.SideA, 2) + Math.Pow(triangleModel.SideC, 2)
            || Math.Pow(triangleModel.SideC, 2) == Math.Pow(triangleModel.SideB, 2) + Math.Pow(triangleModel.SideA, 2);
    }
}

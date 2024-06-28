namespace Lib.ShapesFactory.Models
{
    public record TriangleModel : BaseShapeModel
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
    }
}

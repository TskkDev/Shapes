using Lib.ShapesFactory;
using Lib.ShapesFactory.Interfaces;
using Lib.ShapesFactory.Models;
using Lib.ShapesFactory.Shapes;

namespace LibTests;

[TestClass]
public class ShapeTests
{
    #region PrivateFields

    private IShapeFactory _shapesFactory;

    #endregion

    #region Init

    [TestInitialize]
    public void Initialize()
    {
        _shapesFactory = new ShapesFactory();
    }

    #endregion

    #region TestMethods

    [TestMethod]
    public void CreateShape_WithCircleModel_ReturnsCircle()
    {
        // Arrange
        var circleModel = new CircleModel { Radius = 5.0 };

        // Act
        var result = _shapesFactory.CreateShape<Circle>(circleModel);

        // Assert
        Assert.IsInstanceOfType(result, typeof(Circle));
    }

    [TestMethod]
    public void CreateShape_WithCircleModel_ReturnsCircleArea()
    {
        // Arrange
        var circleModel = new CircleModel { Radius = 5.0 };

        // Act
        var circle = _shapesFactory.CreateShape<Circle>(circleModel);
        var result = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.Round(result,2), 78.54);
    }
    [TestMethod]
    public void CreateShape_WithTriangleModel_ReturnsTriangle()
    {
        // Arrange
        var triangleModel = new TriangleModel { SideA = 3.0, SideB = 4.0, SideC = 5.0 };

        // Act
        var result = _shapesFactory.CreateShape<Triangle>(triangleModel);

        // Assert
        Assert.IsInstanceOfType(result, typeof(Triangle));
    }
    [TestMethod]
    public void CreateShape_WithTriangleModel_ReturnsTriangleArea()
    {
        // Arrange
        var triangleModel = new TriangleModel { SideA = 3.0, SideB = 4.0, SideC = 5.0 };

        // Act
        var triangle = _shapesFactory.CreateShape<Triangle>(triangleModel);
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(result, 6);
    }
    [TestMethod]
    public void CreateShape_WithTriangleModel_ReturnsIsRightTriangle()
    {
        // Arrange
        var triangleModel = new TriangleModel { SideA = 3.0, SideB = 4.0, SideC = 5.0 };

        // Act
        var triangle = _shapesFactory.CreateShape<Triangle>(triangleModel);
        var result = triangle.IsRightTriangle();

        // Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void CreateShape_WithUnsupportedModel_ThrowsException()
    {
        // Arrange
        var unsupportedModel = new UnsupportedModel();

        // Act & Assert
        Assert.ThrowsException<InvalidCastException>(() => _shapesFactory.CreateShape<Triangle>(unsupportedModel));
    }
    [TestMethod]
    public void CreateShape_WithUnsupportedShapeAndUnsupportedModel_ThrowsException()
    {
        // Arrange
        var unsupportedModel = new UnsupportedModel();

        // Act & Assert
        Assert.ThrowsException<NotSupportedException>(() => _shapesFactory.CreateShape<UnsupportedShape>(unsupportedModel));
    }

    #endregion
}

#region Mocks

public record UnsupportedModel : BaseShapeModel
{
    // mock
}
public class UnsupportedShape : BaseShape
{
    //mock
}

#endregion
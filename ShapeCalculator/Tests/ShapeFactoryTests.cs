using ConsoleApp.Services;
using ConsoleApp.Shapes;

namespace Tests
{
    [TestClass]
    public class ShapeFactoryTests
    {
        private IShapeFactory _sut;

        [TestInitialize]
        public void Initialize()
        {
            _sut = new ShapeFactory();
        }

        [TestMethod]
        public void EmptyString_ShapeFactory_ReturnsNull()
        {
            var testInput = string.Empty;
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNull(expectedResult);
        }

        [TestMethod]
        public void NegativeCircle_ShapeFactory_ReturnsNull()
        {
            var testInput = "circle -2";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNull(expectedResult);
        }

        [TestMethod]
        public void NegativeSquare_ShapeFactory_ReturnsNull()
        {
            var testInput = "square -2";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNull(expectedResult);
        }

        [TestMethod]
        public void NegativeRectangle_ShapeFactory_ReturnsNull()
        {
            var testInput = "rectangle -2 3";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNull(expectedResult);
        }

        [TestMethod]
        public void NegativeTriangle_ShapeFactory_ReturnsNull()
        {
            var testInput = "triangle 2 -3";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNull(expectedResult);
        }

        [TestMethod]
        public void SuccessfulCircle_ShapeFactory_ReturnsCircle()
        {
            var testInput = "circle 6";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNotNull(expectedResult);
            Assert.IsInstanceOfType(expectedResult, typeof(Circle));
            Assert.AreEqual(expectedResult.Value1, 6);
            Assert.AreEqual(expectedResult.Value2, 0);
        }

        [TestMethod] public void SuccessfulRectangle_ShapeFactory_ReturnsRectangle()
        {
            var testInput = "rectangle 2.5 7";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNotNull(expectedResult);
            Assert.IsInstanceOfType(expectedResult, typeof(Rectangle));
            Assert.AreEqual(expectedResult.Value1, 2.5);
            Assert.AreEqual(expectedResult.Value2, 7);
        }

        [TestMethod] 
        public void SuccessfulSquare_ShapeFactory_ReturnsSquare()
        {
            var testInput = "square 5";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNotNull(expectedResult);
            Assert.IsInstanceOfType(expectedResult, typeof(Square));
            Assert.AreEqual(expectedResult.Value1, 5);
            Assert.AreEqual(expectedResult.Value2, 0);
        }

        [TestMethod]
        public void SuccessfulTriangle_ShapeFactory_ReturnsTriangle()
        {
            var testInput = "triangle 5 3";
            var expectedResult = _sut.GetShape(testInput);
            Assert.IsNotNull(expectedResult);
            Assert.IsInstanceOfType(expectedResult, typeof(Triangle));
            Assert.AreEqual(expectedResult.Value1, 5);
            Assert.AreEqual(expectedResult.Value2, 3);
        }
    }
}
using ConsoleApp.Shapes;

namespace ConsoleApp.Services;
public class ShapeFactory : IShapeFactory
{
    public Shape? GetShape(string inputData)
    {
        Shape shape = null;
        if (!string.IsNullOrWhiteSpace(inputData))
        {
            var inputValues = inputData.Split(' ');
            var expectedName = inputValues[0].ToLower();
            if (!string.IsNullOrWhiteSpace(expectedName))
            {
                if (expectedName == "circle" && inputValues.Length == 2)
                {
                    double.TryParse(inputValues[1], out var diameter);

                    if (diameter > 0)
                    {
                        shape = new Circle
                        {
                            Value1 = diameter,
                        };
                    }
                }
                else if (expectedName == "rectangle" && inputValues.Length == 3)
                {
                    double.TryParse(inputValues[1], out var width);
                    double.TryParse(inputValues[2], out var length);

                    if (width > 0 && length > 0)
                    {
                        shape = new Rectangle
                        {
                            Value1 = width,
                            Value2 = length
                        };
                    }
                }
                else if (expectedName == "square" && inputValues.Length == 2)
                {
                    double.TryParse(inputValues[1], out var width);

                    if (width > 0)
                    {
                        shape = new Square
                        {
                            Value1 = width
                        };
                    }
                }
                else if (expectedName == "triangle" && inputValues.Length == 3)
                {
                    double.TryParse(inputValues[1], out var width);
                    double.TryParse(inputValues[2], out var length);

                    if (width > 0 && length > 0)
                    {
                        shape = new Triangle
                        {
                            Value1 = width,
                            Value2 = length
                        };
                    }
                }
            }
        }
        return shape;
    }
}
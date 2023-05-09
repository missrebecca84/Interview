using ConsoleApp.Services;
using ConsoleApp.Shapes;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        //Typically these FileService and ShapeFactory classes would be registered within a DI container
      
        var inputData = GetShapeDataFromFile();
        var shapeList = GetShapeListFromInputData(inputData);

        foreach (var shape in shapeList)
        {
            Console.WriteLine($"{shape.Name} {shape.CalculateArea()}");
        }

        Console.ReadLine();
    }

    private static List<Shape> GetShapeListFromInputData(IEnumerable<string> inputData)
    {
        var shapeFactory = new ShapeFactory();
        var shapeList = new List<Shape>();
        foreach (var shapeInput in inputData)
        {
            var shapeResult = shapeFactory.GetShape(shapeInput);
            if (shapeResult != null)
            {
                shapeList.Add(shapeResult);
            }
        }

        shapeList = shapeList.OrderByDescending(a => a.CalculateArea()).ToList();
        return shapeList;
    }

    private static IEnumerable<string> GetShapeDataFromFile()
    {
        var fileService = new FileService();
        var fileName = "inputvalues.txt";
        var directory = Directory.GetCurrentDirectory();
        var pathName = @$"{directory}\{fileName}";

        var inputData = fileService.GetShapesFromFile(pathName);
        return inputData;
    }
}
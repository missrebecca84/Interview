namespace ConsoleApp.Shapes;
public class Triangle : Shape
{
    public override string Name => "triangle";

    public override double CalculateArea()
    {
        return (Value1 * Value2)/2;
    }
}
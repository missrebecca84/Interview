namespace ConsoleApp.Shapes;
public class Rectangle : Shape
{
    public override string Name => "rectangle";
    public override double CalculateArea()
    {
        return Value1 * Value2;
    }
}
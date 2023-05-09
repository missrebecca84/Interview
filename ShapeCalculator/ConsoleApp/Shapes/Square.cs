namespace ConsoleApp.Shapes;
public class Square : Shape
{
    public override string Name => "square";

    public override double CalculateArea()
    {
        return Value1 * Value1;
    }
}
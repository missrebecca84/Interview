using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes;
public class Circle : Shape
{
    public override string Name => "circle";
    public double Radius => Value1 / 2;

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Radius * Radius, 2, MidpointRounding.ToEven);
    }
}
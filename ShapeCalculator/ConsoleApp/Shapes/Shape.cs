using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes;

public abstract class Shape
{
    public virtual string Name => "";
    public double Value1 { get; set; }
    public double Value2 { get; set; }

    public virtual double CalculateArea()
    {
        return 0;
    }
}
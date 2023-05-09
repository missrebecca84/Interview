using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Shapes;

namespace ConsoleApp.Services;
public interface IShapeFactory
{
    Shape? GetShape(string inputData);
}

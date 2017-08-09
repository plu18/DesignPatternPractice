using PrototypePatterApp.AbstractClasses;
using PrototypePatterApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatterApp
{
    class PrototypePatterDemo
    {
        static void Main(string[] args)
        {
            ShapeManager _shapeManager = new ShapeManager();
            
            _shapeManager["1"] = new Circle();
            _shapeManager["2"] = new Square();

            Shape shape1 = _shapeManager["1"].clone() as Shape;
            Shape shape2 = _shapeManager["2"].clone() as Shape;

            shape1.draw();
            shape2.draw();

            Console.ReadKey();
        }
    }
}

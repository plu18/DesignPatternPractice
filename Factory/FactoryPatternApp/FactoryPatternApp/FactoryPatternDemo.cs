using System;
using FactoryPatternApp.Factory;

namespace FactoryPatternApp
{
    class FactoryPatternDemo
    {
        static void Main(string[] args)
        {
            

            AbstractFactory _shapeFactory = FactoryProducer.getFactory("shape");

            Shape _shape1 = _shapeFactory.getShape("circle");
            _shape1.draw();

            Shape _shape2 = _shapeFactory.getShape("square");
            _shape2.draw();

            Shape _shape3 = _shapeFactory.getShape("");
            if(_shape3!=null)
                _shape3.draw();

            AbstractFactory _colorFactory = FactoryProducer.getFactory("color");

            Color _color1 = _colorFactory.getColor("red");
            _color1.fill();

            Color _color2 = _colorFactory.getColor("blue");
            _color2.fill();

            Console.ReadKey();
        }
    }
}
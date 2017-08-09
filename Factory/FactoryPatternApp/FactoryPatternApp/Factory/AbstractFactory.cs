using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    abstract class AbstractFactory
    {
        public abstract Color getColor(string colorName);
        public abstract Shape getShape(string shapeType);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (string.IsNullOrWhiteSpace(shapeType))
                return null;

            if (shapeType.Equals("square", StringComparison.CurrentCultureIgnoreCase))
                return new Square();
            else if (shapeType.Equals("circle", StringComparison.CurrentCultureIgnoreCase))
                return new Circle();

            return null;
        }

        public override Color getColor(string colorName)
        {
            return null;
        }

    }
}

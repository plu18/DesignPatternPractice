using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class ColorFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            return null;
        }

        public override Color getColor(string colorName)
        {
            if (string.IsNullOrWhiteSpace(colorName))
                return null;

            if (colorName.Equals("red", StringComparison.CurrentCultureIgnoreCase))
                return new Red();
            else if (colorName.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
                return new Blue();

            return null;
        }
    }
}

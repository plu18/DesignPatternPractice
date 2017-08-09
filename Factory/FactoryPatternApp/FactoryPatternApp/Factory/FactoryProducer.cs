using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if(choice.Equals("color", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ColorFactory();
            }else if (choice.Equals("shape", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ShapeFactory();
            }
            return null;

        }
    }
}

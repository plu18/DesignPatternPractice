using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }
}

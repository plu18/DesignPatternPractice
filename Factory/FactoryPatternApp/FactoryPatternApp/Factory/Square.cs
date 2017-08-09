using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw a square");
        }
    }
}

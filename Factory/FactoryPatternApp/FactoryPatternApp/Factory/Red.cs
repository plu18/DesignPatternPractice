using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Fill Red");
        }
    }
}

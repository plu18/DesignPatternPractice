using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp.Factory
{
    class Blue : Color
    {
        public void fill()
        {
            Console.WriteLine("Fill Blue");
        }
    }
}

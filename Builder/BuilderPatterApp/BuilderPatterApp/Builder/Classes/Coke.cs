using BuilderPatterApp.Builder.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class Coke : Drink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return (float)1.1;
        }
    }
}

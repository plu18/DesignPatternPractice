using BuilderPatterApp.Builder.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class Milk : Drink
    {
        public override string name()
        {
            return "Milk";
        }

        public override float price()
        {
            return (float)2.5;
        }
    }
}

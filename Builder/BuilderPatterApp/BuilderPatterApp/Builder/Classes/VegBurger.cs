using BuilderPatterApp.Builder.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class VegBurger : Burger
    {
        public override string name()
        {
            return "veg burger";
        }

        public override float price()
        {
            return (float)5.9;
        }
    }
}

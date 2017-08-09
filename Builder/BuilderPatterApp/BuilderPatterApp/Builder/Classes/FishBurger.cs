using BuilderPatterApp.Builder.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class FishBurger : Burger
    {
        public override string name()
        {
            return "Fish Burger";
        }

        public override float price()
        {
            return (float)6.9;
        }
    }
}

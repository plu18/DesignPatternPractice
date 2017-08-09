using BuilderPatterApp.Builder.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.AbstractClasses
{
    abstract class Drink : Item
    {
        public abstract string name();
        public Packing packing()
        {
            return new Bottle();
        }
        public abstract float price();
    }
}

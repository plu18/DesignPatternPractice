using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}

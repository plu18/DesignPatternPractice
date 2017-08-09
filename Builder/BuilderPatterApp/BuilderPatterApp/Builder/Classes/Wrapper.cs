using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class Wrapper : Packing
    {


        string Packing.pack()
        {
            return "Wrapper";
        }
    }
}

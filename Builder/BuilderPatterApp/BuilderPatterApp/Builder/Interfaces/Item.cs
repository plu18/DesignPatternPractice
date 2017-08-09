using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder
{
    interface Item
    {
        String name();
        Packing packing();
        float price();
    }
}

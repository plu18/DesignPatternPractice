using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatterApp.AbstractClasses
{
    abstract class ShapePrototype
    {
        public abstract ShapePrototype clone();
    }
}

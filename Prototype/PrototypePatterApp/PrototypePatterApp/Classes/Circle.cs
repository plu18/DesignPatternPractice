using PrototypePatterApp.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatterApp.Classes
{
    class Circle : Shape
    {
        public override ShapePrototype clone()
        {
            Console.WriteLine("Circle Clone");
            return (ShapePrototype)this.MemberwiseClone();
        }

        public override void draw()
        {
            Console.WriteLine("Circle Draw");
        }


    }
}

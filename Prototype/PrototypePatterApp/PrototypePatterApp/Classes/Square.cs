using PrototypePatterApp.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatterApp.Classes
{
    class Square : Shape
    {

        public override ShapePrototype clone()
        {
            Console.WriteLine("Square Clone");
            return (Shape)this.MemberwiseClone();
        }

        public override void draw()
        {
            Console.WriteLine("Square Draw");
        }
        
    }
}

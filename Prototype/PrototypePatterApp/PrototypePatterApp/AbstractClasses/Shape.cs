using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatterApp.AbstractClasses
{
    abstract class Shape : ShapePrototype
    {

        private string _id;
        private string _type;

        public abstract void draw();

        public string getId()
        {
            return _id;
        }
        
        public void setId(string id)
        {
            _id = id;
        }

        public string getType()
        {
            return _type;
        }
        
    }
}

using PrototypePatterApp.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrototypePatterApp.Classes
{
    class ShapeManager
    {
        private Dictionary<string, Shape> _shapeMap = new Dictionary<string, Shape>();
        

        public Shape this[String shapeId]
        {
            
            get { return _shapeMap[shapeId]; }
            set { _shapeMap.Add(shapeId, value); }

        }
        
    }
}

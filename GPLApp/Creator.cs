using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApp
{
   abstract class Creator
    {
        public abstract ShapesInterface getShape(string ShapeType);
    }
}

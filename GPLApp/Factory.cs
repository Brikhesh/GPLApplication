using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApp
{
    class Factory : Creator
    {
        public override ShapesInterface getShape(string ShapeType)
        {
            ShapeType = ShapeType.ToLower().Trim();
            //if (ShapeType.Equals("circle"))
            //{
            //    return new Circle();
            //}
          if (ShapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            //else if (ShapeType.Equals("triangle"))
            //{
            //    return new Triangle();
            //}
            else
            {
                //throw an appropriate exception.
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + ShapeType + " does not exist");
                throw argEx;
            }
        }
    }
}

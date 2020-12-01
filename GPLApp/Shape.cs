using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApp
{
    abstract class Shape : ShapesInterface
    {
        protected Color color;
        protected int x, y;
       

        public Shape()
        {
           color = Color.Red;
        }
        public Shape(int x, int y)
        {
           this.color = color;
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g);

        public virtual void Set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
        }

    }
}

using System.Drawing;

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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApp
{
    public interface ShapesInterface
    {
        void Set(params int[] list);
        void Draw(Graphics g);
    }
}

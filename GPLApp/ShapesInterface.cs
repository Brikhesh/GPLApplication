using System.Drawing;
namespace GPLApp
{
    public interface ShapesInterface
    {
        void Set(params int[] list);
        void Draw(Graphics g);
    }
}

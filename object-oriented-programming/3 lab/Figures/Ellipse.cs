using System.Drawing;

namespace Figures
{
    public class Ellipse : Figure
    {
        public Ellipse(int id, int x, int y, int r1, int r2) : base(id, x, y)
        {
            w = r1 * 2;
            h = r2 * 2;
            name = "Эллипс";
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}

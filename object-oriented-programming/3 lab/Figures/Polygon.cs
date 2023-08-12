using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygon : Figure
    {
        public Polygon(int id, Point[] points) : base(id, points[0].X, points[0].Y)
        {
            this.points = points;
            name = "Многоугольник";
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += x;
                points[i].Y += y;
            }
            this.x = points[0].X;
            this.y = points[0].Y;
            this.DeleteF(this, false);
            this.Draw();
        }
    }
}

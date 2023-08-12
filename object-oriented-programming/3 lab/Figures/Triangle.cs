using System.Drawing;

namespace Figures
{
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points) : base(id, points)
        {
            name = "Треугольник";
        }
    }
}

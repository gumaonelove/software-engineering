using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Human : Rectangle
    {
        public List<Figure> figures;
        public Human(int id, int x, int y, int w, int h) : base(id, x, y, w, h)
        {
            name = "Человек";
            figures = new List<Figure>();
            Rectangle r1 = new Rectangle(0, x, y + 65, 25, 1);
            Rectangle r2 = new Rectangle(0, x + 85, y + 65, 25, 1);
            Rectangle r3 = new Rectangle(0, x + 25, y + 50, 60, 80);
            Rectangle r4 = new Rectangle(0, x + 40, y + 130, 1, 35);
            Rectangle r5 = new Rectangle(0, x + 70, y + 130, 1, 35);
            Circle c1 = new Circle(0, x + 35, y + 10, 20);
            Circle c2 = new Circle(0, x + 42, y + 20, 5);
            Circle c3 = new Circle(0, x + 58, y + 20, 5);
            Rectangle r6 = new Rectangle(0, x + 43, y, 1, 12);
            Rectangle r7 = new Rectangle(0, x + 63, y, 1, 12);
            Rectangle r8 = new Rectangle(0, x + 50, y + 37, 10, 1);
            Figure[] f_list = { r1, r2, r3, r4, r5, r6, r7, r8, c1, c2, c3 };
            figures.AddRange(f_list);
        }
        public override void Draw()
        {
            foreach (Figure f in figures)
            {
                f.Draw();
            }
        }
        public override void MoveTo(int x, int y)
        {
            Init.Clear();
            this.x += x;
            this.y += y;
            for (int i = 0; i < 11; i++)
            {
                Figure figure = figures[i];
                figure.x += x;
                figure.y += y;

            }
            Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
    }
}

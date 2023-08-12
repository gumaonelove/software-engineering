using System.Drawing;

namespace Figures
{
    /// <summary>
    /// Класс для представления абстрактной фигуры
    /// </summary>
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int id;
        public string name;
        public string user_name;
        public Point[] points;
        public Figure(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = "Фигура";
        }
        abstract public void Draw();
        virtual public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            ShapeContainer.figureList.Remove(figure);
            Init.Clear();
            Init.pictureBox.Image = Init.bitmap;
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
            if (flag == false)
            {
                ShapeContainer.figureList.Add(figure);
            }
        }
        virtual public string Info
        {
            get
            {
                return $"Фигура {user_name}: X = {x}, Y = {y}";
            }
        }
    }
}

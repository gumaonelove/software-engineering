using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    /// <summary>
    /// Вспомогательный класс. Содержит свойства и методы, доступ к которым
    /// необходим из любого участка кода программы.
    /// </summary>
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
        public static ListBox figuresListBox;
        /// <summary>
        /// Метод, проверяющий, вышла ли фигура за пределы окна.
        /// </summary>
        /// <param name="x">Верхний левый угол фигуры - x</param>
        /// <param name="y">Верхний левый угол фигуры - y</param>
        /// <param name="w">Ширина фигуры</param>
        /// <param name="h">Высота фигуры</param>
        /// <returns>Возвращает true, если фигуры не вышла за пределы фигуры</returns>
        public static bool Coords_check(int x, int y, int w, int h)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.pictureBox.Width) || (y + h > Init.pictureBox.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Перегрузка прошлого метода. Для фигуры, которые задаются массивом точек.
        /// </summary>
        /// <param name="points">Массив точек, задающий фигуру</param>
        /// <param name="x">смещение по оси х</param>
        /// <param name="y">смещение по оси y</param>
        /// <returns>Перемещение фигуры</returns>
        public static bool Coords_check(Point[] points, int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if ((points[i].X + x < 0) || (points[i].Y + y < 0) || (points[i].X + x > Init.pictureBox.Width) ||
                    (points[i].Y + y > Init.pictureBox.Height))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод, очищающий окно.
        /// </summary>
        public static void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
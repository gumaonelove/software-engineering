using System.Collections.Generic;

namespace Figures
{
    /// <summary>
    /// Класс списка фигур
    /// </summary>
    public class ShapeContainer
    {
        public static List<Figure> figureList;
        /// <summary>
        /// Иницилизация списка фигур
        /// </summary>
        public ShapeContainer()
        {
            figureList = new List<Figure>();
        }
        /// <summary>
        /// Добавление фигуры в список
        /// </summary>
        /// <param name="figure">Фигура, которую необходимо добавить</param>
        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }
    }
}
using System.Collections.Generic;

namespace Figures
{
    public class ShapeContainer
    {
        public static List<Figure> figureList;
        public ShapeContainer()
        {
            figureList = new List<Figure>();
        }
        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }
    }
}

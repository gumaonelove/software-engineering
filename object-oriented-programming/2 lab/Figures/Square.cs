namespace Figures
{
    public class Square : Rectangle
    {
        public Square(int id, int x, int y, int w) : base(id, x, y, w, w)
        {
            name = "Квадрат";
        }
    }
}

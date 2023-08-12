namespace Figures
{
    public class Square : Rectangle
    {
        public string user_name;
        public Square(int id, int x, int y, int w, string name) : base(id, x, y, w, w)
        {
            user_name = name;
            this.name = "Квадрат";
        }
    }
}

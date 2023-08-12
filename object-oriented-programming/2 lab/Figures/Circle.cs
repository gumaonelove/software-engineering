namespace Figures
{
    public class Circle : Ellipse
    {
        public Circle(int id, int x, int y, int r) : base(id, x, y, r, r)
        {
            this.name = "Окружность";
        }
    }
}

﻿namespace Figures
{
    public class Square : Rectangle
    {
        public Square(int id, int x, int y, int w, string name) : base(id, x, y, w, w)
        {
            user_name = name;
            this.name = "Квадрат";
        }
    }
}

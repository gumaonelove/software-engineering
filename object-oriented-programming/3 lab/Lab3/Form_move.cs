using System;
using Figures;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form_move : Form
    {
        List<Figure> temp;
        public Form_move()
        {
            InitializeComponent();
        }

        private void Btn_move_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if ((figure.ToString() == "Figures.Polygon") || (figure.ToString() == "Figures.Triangle"))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_all_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if ((figure.ToString() == "Figures.Polygon") || (figure.ToString() == "Figures.Triangle"))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_rect_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Rectangle))
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_sq_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Square))
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_ellipse_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Ellipse))
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_circle_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Circle))
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_poly_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Polygon))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_triangle_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Triangle))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void Btn_move_man_Click(object sender, EventArgs e)
        {
            temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if (figure.GetType() == typeof(Human))
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}

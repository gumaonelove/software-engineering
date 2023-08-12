using Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void change_rect_Click(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(change_rect_w.Text);
                int h = int.Parse(change_rect_h.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.ToString() == "Figures.Rectangle")
                    {
                        if (Init.Coords_check(figure.x, figure.y, w, h))
                        {
                            figure.w = w;
                            figure.h = h;
                            figure.DeleteF(figure, false);
                            figure.Draw();
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы выбрали не прямоугольник.");
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
    }
}

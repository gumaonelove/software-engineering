using System;
using Figures;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form_rect : Form
    {
        Form1 form_1;
        public Form_rect(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void Rect_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(rect_x.Text);
                int y = int.Parse(rect_y.Text);
                int w = int.Parse(rect_w.Text);
                int h = int.Parse(rect_h.Text);
                if (Init.Coords_check(x, y, w, h))
                {
                    form_1.rect_count += 1;
                    Figures.Rectangle rectangle = new Figures.Rectangle(form_1.rect_count, x, y, w, h);
                    ShapeContainer.AddFigure(rectangle);
                    form_1.bs.ResetBindings(false);
                    rectangle.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}

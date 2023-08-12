using System;
using Figures;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form_sq : Form
    {
        Form1 form_1;
        public Form_sq(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void Sq_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(sq_x.Text);
                int y = int.Parse(sq_y.Text);
                int w = int.Parse(sq_w.Text);
                if (Init.Coords_check(x, y, w, w))
                {
                    form_1.sq_count += 1;
                    Square square = new Square(form_1.sq_count, x, y, w);
                    ShapeContainer.AddFigure(square);
                    form_1.bs.ResetBindings(false);
                    square.Draw();
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

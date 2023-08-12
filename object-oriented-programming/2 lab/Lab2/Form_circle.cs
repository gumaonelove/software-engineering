using System;
using Figures;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form_circle : Form
    {
        Form1 form_1;
        public Form_circle(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void Circle_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(circ_x.Text);
                int y = int.Parse(circ_y.Text);
                int r = int.Parse(circ_r.Text);
                if (Init.Coords_check(x, y, r * 2, r * 2))
                {
                    form_1.circle_count += 1;
                    Circle circle = new Circle(form_1.circle_count, x, y, r);
                    ShapeContainer.AddFigure(circle);
                    form_1.bs.ResetBindings(false);
                    circle.Draw();
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

using System;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Lab2
{
    public partial class Form_triangle : Form
    {
        Form1 form_1;
        public Form_triangle(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;

        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(x_1.Text);
                int y1 = int.Parse(y_1.Text);
                int x2 = int.Parse(x_2.Text);
                int y2 = int.Parse(y_2.Text);
                int x3 = int.Parse(x_3.Text);
                int y3 = int.Parse(y_3.Text);
                Point pt1 = new Point(x1, y1);
                Point pt2 = new Point(x2, y2);
                Point pt3 = new Point(x3, y3);
                Point[] points = { pt1, pt2, pt3 };
                if (Init.Coords_check(points, 0, 0))
                {
                    form_1.triangle_count += 1;
                    Triangle triangle = new Triangle(form_1.triangle_count, points);
                    ShapeContainer.AddFigure(triangle);
                    form_1.bs.ResetBindings(false);
                    triangle.Draw();
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}

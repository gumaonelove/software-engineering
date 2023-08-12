using System;
using Figures;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form_ellipse : Form
    {
        Form1 form_1;
        public Form_ellipse(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void El_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(el_x.Text);
                int y = int.Parse(el_y.Text);
                int r1 = int.Parse(el_r1.Text);
                int r2 = int.Parse(el_r2.Text);
                if (Init.Coords_check(x, y, r1 * 2, r2 * 2))
                {
                    form_1.ellipse_count += 1;
                    Ellipse ellipse = new Ellipse(form_1.ellipse_count, x, y, r1, r2);
                    ShapeContainer.AddFigure(ellipse);
                    form_1.bs.ResetBindings(false);
                    ellipse.Draw();
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

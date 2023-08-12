using System;
using System.Windows.Forms;
using Figures;

namespace Lab2
{
    public partial class Form_human : Form
    {
        Form1 form_1;
        public Form_human(Form1 form_1)
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
                if (Init.Coords_check(x, y, 110, 165))
                {
                    form_1.human_count += 1;
                    Human human = new Human(form_1.human_count, x, y, 110, 165);
                    ShapeContainer.AddFigure(human);
                    form_1.bs.ResetBindings(false);
                    human.Draw();
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

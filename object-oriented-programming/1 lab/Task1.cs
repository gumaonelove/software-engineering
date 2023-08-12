using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(x_in.Text);
                float y = float.Parse(y_in.Text);
                float z = float.Parse(z_in.Text);
                if (x >= y && y >= z)
                {
                    x_out.Text = (x * 2).ToString();
                    y_out.Text = (y * 2).ToString();
                    z_out.Text = (z * 2).ToString();
                }
                else
                {
                    x_out.Text = Math.Abs(x).ToString();
                    y_out.Text = Math.Abs(y).ToString();
                    z_out.Text = Math.Abs(z).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}

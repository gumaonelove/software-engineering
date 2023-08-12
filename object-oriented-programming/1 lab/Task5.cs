using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task5 : Form
    {
        int[] ary;
        public Task5()
        {
            InitializeComponent();
        }

        private void Btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(n_in.Text);
                ary = new int[n];
                res_textBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int elem = int.Parse(textBox2.Text);
                ary[n] = elem;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода или размерность массива не указана");
            }
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            show_label.Text = "";
            if (ary != null)
            {
                for (int i = 0; i < ary.Length; i++)
                {
                    show_label.Text += ary[i].ToString() + " ";
                }
            }
            else
            {
                MessageBox.Show("Размерность массива не указана");
            }
        }

        private void Btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                int max_elem = ary.Max();
                int max_index = Array.IndexOf(ary, max_elem);
                res_textBox.Text = max_elem.ToString();
                res_textBox2.Text = max_index.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Размерность массива не указана");
            }
        }
    }
}

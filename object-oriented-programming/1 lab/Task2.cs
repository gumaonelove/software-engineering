using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                float res;

                float time = float.Parse(time_in.Text);
                float price = float.Parse(price_in.Text);
                string day = Day_listBox.Text;
                if ((time > 0) && (price > 0) && (day != ""))
                {
                    res = time * price;
                    if (day == "Воскресенье")
                    {
                        res = (float)(res * 0.8);
                    }
                    out_textBox1.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Введенные данные некорректны");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}

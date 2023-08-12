using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task4 : Form
    {
        int count = 0;
        public Task4()
        {
            InitializeComponent();
        }

        private void Btn_reroll_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(m_in.Text);
                int n = int.Parse(n_in.Text);
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = n;

                var rand = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rand.Next(1000);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }

        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        double elem = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        if ((elem > 9) && (elem < 100))
                        {
                            count += 1;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Элемент матрицы на позиции {i + 1} {j + 1} некорректен");
                    }
                }
            }
            textBox1.Text = count.ToString();
        }
    }
}

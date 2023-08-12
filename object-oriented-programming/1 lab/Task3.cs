using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task3 : Form
    {
        int order = 9;
        int count;
        double max_elem;
        double res;
        public Task3()
        {
            InitializeComponent();
            dataGridView1.RowCount = order;
            dataGridView1.ColumnCount = order;
            Generate_matrix();
        }

        public void Generate_matrix()
        {
            var rand = new Random();
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(1000);
                }
            }
        }
        public void Find_max()
        {
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if (i > j)
                    {
                        try
                        {
                            double elem = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                            if (elem > max_elem)
                            {
                                max_elem = elem;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Элемент матрицы на позиции {i + 1} {j + 1} некорректен");
                        }
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            count = 0;
            res = 0;
            max_elem = 0;
            res_label.Text = "";
            res_textBox.Text = "";

            Find_max();

            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if (i <= j)
                    {
                        try
                        {
                            double elem = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                            if (elem > max_elem)
                            {
                                res += elem;
                                count += 1;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Элемент матрицы на позиции {i + 1} {j + 1} некорректен");
                        }
                    }
                }
            }
            if (count > 0)
            {
                res_textBox.Text = res.ToString();
            }
            else
            {
                res_label.Text = "Нет элементов с указанным свойством";
            }
        }

        private void Btn_reroll_Click(object sender, EventArgs e)
        {
            Generate_matrix();
        }
    }
}

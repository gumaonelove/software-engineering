using System;
using System.IO;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_task1_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Tasks\Task1.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            taskTextBox1.Text = text;
        }

        private void Btn_task2_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Tasks\Task2.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            taskTextBox1.Text = text;
        }

        private void Btn_task3_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Tasks\Task3.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            taskTextBox1.Text = text;
        }

        private void Btn_task4_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Tasks\Task4.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            taskTextBox1.Text = text;
        }

        private void Btn_task5_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Tasks\Task5.txt";
            StreamReader reader = new StreamReader(path);
            string text = reader.ReadToEnd();
            taskTextBox1.Text = text;
        }

        private void Btn_task1_Click(object sender, EventArgs e)
        {
            Form f1 = new Task1();
            f1.Show();
        }

        private void Btn_task2_Click(object sender, EventArgs e)
        {
            Form f2 = new Task2();
            f2.Show();
        }

        private void Btn_task3_Click(object sender, EventArgs e)
        {
            Form f3 = new Task3();
            f3.Show();
        }

        private void Btn_task4_Click(object sender, EventArgs e)
        {
            Form f4 = new Task4();
            f4.Show();
        }

        private void Btn_task5_Click(object sender, EventArgs e)
        {
            Form f5 = new Task5();
            f5.Show();
        }
    }
}

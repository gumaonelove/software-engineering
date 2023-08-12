using Figures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public BindingSource bs = new BindingSource();
        public int rect_count = 0;
        public int sq_count = 0;
        public int ellipse_count = 0;
        public int circle_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
            Init.figuresListBox = figuresListBox;

            ShapeContainer figure_list = new ShapeContainer();
            bs.DataSource = ShapeContainer.figureList;
            Init.figuresListBox.DataSource = bs;
            Init.figuresListBox.DisplayMember = "Name";
        }
        private void Btn_rect_Click(object sender, EventArgs e)
        {
            Form f_rect = new Form_rect(this);
            f_rect.Show();
        }

        private void Btn_sq_Click(object sender, EventArgs e)
        {
            Form f_sq = new Form_sq(this);
            f_sq.Show();
        }

        private void Btn_ellipse_Click(object sender, EventArgs e)
        {
            Form f_ellipse = new Form_ellipse(this);
            f_ellipse.Show();
        }

        private void Btn_circle_Click(object sender, EventArgs e)
        {
            Form f_circle = new Form_circle(this);
            f_circle.Show();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Init.figuresListBox.SelectedIndex != -1)
            {
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                figure.DeleteF(figure, true);
                bs.ResetBindings(false);
            }
        }

        private void move_button_Click(object sender, EventArgs e)
        {
            Form f_move = new Form_move();
            f_move.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }
    }
}

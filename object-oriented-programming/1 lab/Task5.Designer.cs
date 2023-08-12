namespace Lab1
{
    partial class Task5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.n_in = new System.Windows.Forms.TextBox();
            this.Btn_set = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Btn_show = new System.Windows.Forms.Button();
            this.show_label = new System.Windows.Forms.Label();
            this.Btn_find = new System.Windows.Forms.Button();
            this.res_textBox = new System.Windows.Forms.TextBox();
            this.res_textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите и задайте\r\nразмерность массива:";
            // 
            // n_in
            // 
            this.n_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_in.Location = new System.Drawing.Point(217, 12);
            this.n_in.Name = "n_in";
            this.n_in.Size = new System.Drawing.Size(52, 27);
            this.n_in.TabIndex = 13;
            // 
            // Btn_set
            // 
            this.Btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_set.Location = new System.Drawing.Point(275, 12);
            this.Btn_set.Name = "Btn_set";
            this.Btn_set.Size = new System.Drawing.Size(99, 27);
            this.Btn_set.TabIndex = 14;
            this.Btn_set.Text = "Задать";
            this.Btn_set.UseVisualStyleBackColor = true;
            this.Btn_set.Click += new System.EventHandler(this.Btn_set_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Укажите индекс элемента:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Укажите значение элемента:\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(274, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(275, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 18;
            // 
            // Btn_add
            // 
            this.Btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_add.Location = new System.Drawing.Point(16, 133);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(96, 27);
            this.Btn_add.TabIndex = 19;
            this.Btn_add.Text = "Добавить";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_show
            // 
            this.Btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_show.Location = new System.Drawing.Point(16, 166);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(96, 27);
            this.Btn_show.TabIndex = 20;
            this.Btn_show.Text = "Показать";
            this.Btn_show.UseVisualStyleBackColor = true;
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // show_label
            // 
            this.show_label.AutoSize = true;
            this.show_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_label.Location = new System.Drawing.Point(12, 209);
            this.show_label.Name = "show_label";
            this.show_label.Size = new System.Drawing.Size(0, 20);
            this.show_label.TabIndex = 21;
            // 
            // Btn_find
            // 
            this.Btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_find.Location = new System.Drawing.Point(115, 133);
            this.Btn_find.Name = "Btn_find";
            this.Btn_find.Size = new System.Drawing.Size(124, 60);
            this.Btn_find.TabIndex = 22;
            this.Btn_find.Text = "Найти максимальный";
            this.Btn_find.UseVisualStyleBackColor = true;
            this.Btn_find.Click += new System.EventHandler(this.Btn_find_Click);
            // 
            // res_textBox
            // 
            this.res_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textBox.Location = new System.Drawing.Point(275, 133);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.ReadOnly = true;
            this.res_textBox.Size = new System.Drawing.Size(100, 27);
            this.res_textBox.TabIndex = 23;
            // 
            // res_textBox2
            // 
            this.res_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textBox2.Location = new System.Drawing.Point(275, 166);
            this.res_textBox2.Name = "res_textBox2";
            this.res_textBox2.ReadOnly = true;
            this.res_textBox2.Size = new System.Drawing.Size(100, 27);
            this.res_textBox2.TabIndex = 24;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 302);
            this.Controls.Add(this.res_textBox2);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.Btn_find);
            this.Controls.Add(this.show_label);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_set);
            this.Controls.Add(this.n_in);
            this.Controls.Add(this.label1);
            this.Name = "Task5";
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_in;
        private System.Windows.Forms.Button Btn_set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Btn_show;
        private System.Windows.Forms.Label show_label;
        private System.Windows.Forms.Button Btn_find;
        private System.Windows.Forms.TextBox res_textBox;
        private System.Windows.Forms.TextBox res_textBox2;
    }
}
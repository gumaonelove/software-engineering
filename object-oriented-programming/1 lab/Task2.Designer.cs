namespace Lab1
{
    partial class Task2
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
            this.time_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Day_listBox = new System.Windows.Forms.ListBox();
            this.Btn = new System.Windows.Forms.Button();
            this.out_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_in
            // 
            this.time_in.Location = new System.Drawing.Point(372, 18);
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(100, 22);
            this.time_in.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество минут разговора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите цену за минуту разговора:";
            // 
            // price_in
            // 
            this.price_in.Location = new System.Drawing.Point(372, 57);
            this.price_in.Name = "price_in";
            this.price_in.Size = new System.Drawing.Size(100, 22);
            this.price_in.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите день недели\r\n\r\n";
            // 
            // Day_listBox
            // 
            this.Day_listBox.FormattingEnabled = true;
            this.Day_listBox.ItemHeight = 16;
            this.Day_listBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.Day_listBox.Location = new System.Drawing.Point(16, 122);
            this.Day_listBox.Name = "Day_listBox";
            this.Day_listBox.Size = new System.Drawing.Size(112, 116);
            this.Day_listBox.TabIndex = 5;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(16, 255);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(112, 47);
            this.Btn.TabIndex = 6;
            this.Btn.Text = "Вычислить";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // out_textBox1
            // 
            this.out_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out_textBox1.Location = new System.Drawing.Point(372, 254);
            this.out_textBox1.Name = "out_textBox1";
            this.out_textBox1.ReadOnly = true;
            this.out_textBox1.Size = new System.Drawing.Size(100, 38);
            this.out_textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена:\r\n";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.out_textBox1);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Day_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_in);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox time_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Day_listBox;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox out_textBox1;
        private System.Windows.Forms.Label label4;
    }
}
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_task1 = new System.Windows.Forms.Button();
            this.taskTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_task2 = new System.Windows.Forms.Button();
            this.Btn_task3 = new System.Windows.Forms.Button();
            this.Btn_task4 = new System.Windows.Forms.Button();
            this.Btn_task5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_task1
            // 
            this.Btn_task1.Location = new System.Drawing.Point(12, 12);
            this.Btn_task1.Name = "Btn_task1";
            this.Btn_task1.Size = new System.Drawing.Size(103, 43);
            this.Btn_task1.TabIndex = 0;
            this.Btn_task1.Text = "Задание 1";
            this.Btn_task1.UseVisualStyleBackColor = true;
            this.Btn_task1.Click += new System.EventHandler(this.Btn_task1_Click);
            this.Btn_task1.MouseEnter += new System.EventHandler(this.Btn_task1_MouseEnter);
            // 
            // taskTextBox1
            // 
            this.taskTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.taskTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTextBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTextBox1.ForeColor = System.Drawing.Color.Black;
            this.taskTextBox1.Location = new System.Drawing.Point(50, 127);
            this.taskTextBox1.Name = "taskTextBox1";
            this.taskTextBox1.ReadOnly = true;
            this.taskTextBox1.Size = new System.Drawing.Size(500, 200);
            this.taskTextBox1.TabIndex = 2;
            this.taskTextBox1.Text = "\n";
            // 
            // Btn_task2
            // 
            this.Btn_task2.Location = new System.Drawing.Point(132, 12);
            this.Btn_task2.Name = "Btn_task2";
            this.Btn_task2.Size = new System.Drawing.Size(103, 43);
            this.Btn_task2.TabIndex = 3;
            this.Btn_task2.Text = "Задание 2";
            this.Btn_task2.UseVisualStyleBackColor = true;
            this.Btn_task2.Click += new System.EventHandler(this.Btn_task2_Click);
            this.Btn_task2.MouseEnter += new System.EventHandler(this.Btn_task2_MouseEnter);
            // 
            // Btn_task3
            // 
            this.Btn_task3.Location = new System.Drawing.Point(254, 12);
            this.Btn_task3.Name = "Btn_task3";
            this.Btn_task3.Size = new System.Drawing.Size(103, 43);
            this.Btn_task3.TabIndex = 4;
            this.Btn_task3.Text = "Задание 3";
            this.Btn_task3.UseVisualStyleBackColor = true;
            this.Btn_task3.Click += new System.EventHandler(this.Btn_task3_Click);
            this.Btn_task3.MouseEnter += new System.EventHandler(this.Btn_task3_MouseEnter);
            // 
            // Btn_task4
            // 
            this.Btn_task4.Location = new System.Drawing.Point(373, 12);
            this.Btn_task4.Name = "Btn_task4";
            this.Btn_task4.Size = new System.Drawing.Size(103, 43);
            this.Btn_task4.TabIndex = 5;
            this.Btn_task4.Text = "Задание 4";
            this.Btn_task4.UseVisualStyleBackColor = true;
            this.Btn_task4.Click += new System.EventHandler(this.Btn_task4_Click);
            this.Btn_task4.MouseEnter += new System.EventHandler(this.Btn_task4_MouseEnter);
            // 
            // Btn_task5
            // 
            this.Btn_task5.Location = new System.Drawing.Point(496, 12);
            this.Btn_task5.Name = "Btn_task5";
            this.Btn_task5.Size = new System.Drawing.Size(103, 43);
            this.Btn_task5.TabIndex = 6;
            this.Btn_task5.Text = "Задание 5";
            this.Btn_task5.UseVisualStyleBackColor = true;
            this.Btn_task5.Click += new System.EventHandler(this.Btn_task5_Click);
            this.Btn_task5.MouseEnter += new System.EventHandler(this.Btn_task5_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Текст задания";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_task5);
            this.Controls.Add(this.Btn_task4);
            this.Controls.Add(this.Btn_task3);
            this.Controls.Add(this.Btn_task2);
            this.Controls.Add(this.taskTextBox1);
            this.Controls.Add(this.Btn_task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_task1;
        private System.Windows.Forms.RichTextBox taskTextBox1;
        private System.Windows.Forms.Button Btn_task2;
        private System.Windows.Forms.Button Btn_task3;
        private System.Windows.Forms.Button Btn_task4;
        private System.Windows.Forms.Button Btn_task5;
        private System.Windows.Forms.Label label1;
    }
}


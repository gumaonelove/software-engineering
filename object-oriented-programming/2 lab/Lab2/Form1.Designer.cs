namespace Lab2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.figuresListBox = new System.Windows.Forms.ListBox();
            this.Btn_move = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Btn_rect = new System.Windows.Forms.Button();
            this.Btn_sq = new System.Windows.Forms.Button();
            this.Btn_ellipse = new System.Windows.Forms.Button();
            this.Btn_circle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(144, 584);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(144, 29);
            this.Btn_delete.TabIndex = 33;
            this.Btn_delete.Text = "удалить";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // figuresListBox
            // 
            this.figuresListBox.FormattingEnabled = true;
            this.figuresListBox.ItemHeight = 16;
            this.figuresListBox.Location = new System.Drawing.Point(144, 481);
            this.figuresListBox.Name = "figuresListBox";
            this.figuresListBox.Size = new System.Drawing.Size(144, 100);
            this.figuresListBox.TabIndex = 34;
            // 
            // Btn_move
            // 
            this.Btn_move.Location = new System.Drawing.Point(12, 489);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(117, 60);
            this.Btn_move.TabIndex = 35;
            this.Btn_move.Text = "меню перемещения";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.move_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 40;
            this.button1.Text = "изменить прямоугольник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 41;
            this.button2.Text = "изменить квадрат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 42;
            this.button3.Text = "изменить эллипс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 42);
            this.button4.TabIndex = 43;
            this.button4.Text = "изменить окружность";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_rect
            // 
            this.Btn_rect.Location = new System.Drawing.Point(12, 37);
            this.Btn_rect.Name = "Btn_rect";
            this.Btn_rect.Size = new System.Drawing.Size(123, 42);
            this.Btn_rect.TabIndex = 44;
            this.Btn_rect.Text = "Прямоугольник";
            this.Btn_rect.UseVisualStyleBackColor = true;
            this.Btn_rect.Click += new System.EventHandler(this.Btn_rect_Click);
            // 
            // Btn_sq
            // 
            this.Btn_sq.Location = new System.Drawing.Point(165, 37);
            this.Btn_sq.Name = "Btn_sq";
            this.Btn_sq.Size = new System.Drawing.Size(123, 42);
            this.Btn_sq.TabIndex = 45;
            this.Btn_sq.Text = "Квадрат";
            this.Btn_sq.UseVisualStyleBackColor = true;
            this.Btn_sq.Click += new System.EventHandler(this.Btn_sq_Click);
            // 
            // Btn_ellipse
            // 
            this.Btn_ellipse.Location = new System.Drawing.Point(321, 37);
            this.Btn_ellipse.Name = "Btn_ellipse";
            this.Btn_ellipse.Size = new System.Drawing.Size(123, 42);
            this.Btn_ellipse.TabIndex = 46;
            this.Btn_ellipse.Text = "Эллипс";
            this.Btn_ellipse.UseVisualStyleBackColor = true;
            this.Btn_ellipse.Click += new System.EventHandler(this.Btn_ellipse_Click);
            // 
            // Btn_circle
            // 
            this.Btn_circle.Location = new System.Drawing.Point(482, 37);
            this.Btn_circle.Name = "Btn_circle";
            this.Btn_circle.Size = new System.Drawing.Size(123, 42);
            this.Btn_circle.TabIndex = 47;
            this.Btn_circle.Text = "Окружность";
            this.Btn_circle.UseVisualStyleBackColor = true;
            this.Btn_circle.Click += new System.EventHandler(this.Btn_circle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(206, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 25);
            this.label17.TabIndex = 48;
            this.label17.Text = "Создание фигур";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 625);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Btn_circle);
            this.Controls.Add(this.Btn_ellipse);
            this.Controls.Add(this.Btn_sq);
            this.Controls.Add(this.Btn_rect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_move);
            this.Controls.Add(this.figuresListBox);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.ListBox figuresListBox;
        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Btn_rect;
        private System.Windows.Forms.Button Btn_sq;
        private System.Windows.Forms.Button Btn_ellipse;
        private System.Windows.Forms.Button Btn_circle;
        private System.Windows.Forms.Label label17;
    }
}


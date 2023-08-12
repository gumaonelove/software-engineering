namespace Lab2
{
    partial class Form_rect
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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rect_h = new System.Windows.Forms.TextBox();
            this.rect_w = new System.Windows.Forms.TextBox();
            this.rect_y = new System.Windows.Forms.TextBox();
            this.rect_x = new System.Windows.Forms.TextBox();
            this.Rect_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "H:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "W:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "X:";
            // 
            // rect_h
            // 
            this.rect_h.Location = new System.Drawing.Point(65, 116);
            this.rect_h.Name = "rect_h";
            this.rect_h.Size = new System.Drawing.Size(194, 22);
            this.rect_h.TabIndex = 34;
            // 
            // rect_w
            // 
            this.rect_w.Location = new System.Drawing.Point(65, 88);
            this.rect_w.Name = "rect_w";
            this.rect_w.Size = new System.Drawing.Size(194, 22);
            this.rect_w.TabIndex = 33;
            // 
            // rect_y
            // 
            this.rect_y.Location = new System.Drawing.Point(65, 60);
            this.rect_y.Name = "rect_y";
            this.rect_y.Size = new System.Drawing.Size(194, 22);
            this.rect_y.TabIndex = 32;
            // 
            // rect_x
            // 
            this.rect_x.Location = new System.Drawing.Point(65, 32);
            this.rect_x.Name = "rect_x";
            this.rect_x.Size = new System.Drawing.Size(194, 22);
            this.rect_x.TabIndex = 31;
            // 
            // Rect_create
            // 
            this.Rect_create.Location = new System.Drawing.Point(12, 156);
            this.Rect_create.Name = "Rect_create";
            this.Rect_create.Size = new System.Drawing.Size(247, 42);
            this.Rect_create.TabIndex = 30;
            this.Rect_create.Text = "Создать";
            this.Rect_create.UseVisualStyleBackColor = true;
            this.Rect_create.Click += new System.EventHandler(this.Rect_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Введите параметры фигуры";
            // 
            // Form_rect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rect_h);
            this.Controls.Add(this.rect_w);
            this.Controls.Add(this.rect_y);
            this.Controls.Add(this.rect_x);
            this.Controls.Add(this.Rect_create);
            this.Name = "Form_rect";
            this.Text = "Form_rect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rect_h;
        private System.Windows.Forms.TextBox rect_w;
        private System.Windows.Forms.TextBox rect_y;
        private System.Windows.Forms.TextBox rect_x;
        private System.Windows.Forms.Button Rect_create;
        private System.Windows.Forms.Label label2;
    }
}
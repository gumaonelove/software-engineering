namespace Lab2
{
    partial class Form_human
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rect_y = new System.Windows.Forms.TextBox();
            this.rect_x = new System.Windows.Forms.TextBox();
            this.Rect_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Введите параметры фигуры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "X:";
            // 
            // rect_y
            // 
            this.rect_y.Location = new System.Drawing.Point(69, 60);
            this.rect_y.Name = "rect_y";
            this.rect_y.Size = new System.Drawing.Size(194, 22);
            this.rect_y.TabIndex = 41;
            // 
            // rect_x
            // 
            this.rect_x.Location = new System.Drawing.Point(69, 32);
            this.rect_x.Name = "rect_x";
            this.rect_x.Size = new System.Drawing.Size(194, 22);
            this.rect_x.TabIndex = 40;
            // 
            // Rect_create
            // 
            this.Rect_create.Location = new System.Drawing.Point(16, 101);
            this.Rect_create.Name = "Rect_create";
            this.Rect_create.Size = new System.Drawing.Size(247, 42);
            this.Rect_create.TabIndex = 45;
            this.Rect_create.Text = "Создать";
            this.Rect_create.UseVisualStyleBackColor = true;
            this.Rect_create.Click += new System.EventHandler(this.Rect_create_Click);
            // 
            // Form_human
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.Rect_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rect_y);
            this.Controls.Add(this.rect_x);
            this.Name = "Form_human";
            this.Text = "Form_human";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rect_y;
        private System.Windows.Forms.TextBox rect_x;
        private System.Windows.Forms.Button Rect_create;
    }
}
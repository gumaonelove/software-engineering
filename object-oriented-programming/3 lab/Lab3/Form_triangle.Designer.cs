namespace Lab2
{
    partial class Form_triangle
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
            this.x_1 = new System.Windows.Forms.TextBox();
            this.Btn_create = new System.Windows.Forms.Button();
            this.y_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.y_2 = new System.Windows.Forms.TextBox();
            this.x_2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.y_3 = new System.Windows.Forms.TextBox();
            this.x_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задайте координаты трех точек треугольника:";
            // 
            // x_1
            // 
            this.x_1.Location = new System.Drawing.Point(63, 44);
            this.x_1.Name = "x_1";
            this.x_1.Size = new System.Drawing.Size(60, 22);
            this.x_1.TabIndex = 1;
            // 
            // Btn_create
            // 
            this.Btn_create.Location = new System.Drawing.Point(12, 110);
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Size = new System.Drawing.Size(168, 36);
            this.Btn_create.TabIndex = 2;
            this.Btn_create.Text = "Создать треугольник";
            this.Btn_create.UseVisualStyleBackColor = true;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // y_1
            // 
            this.y_1.Location = new System.Drawing.Point(63, 72);
            this.y_1.Name = "y_1";
            this.y_1.Size = new System.Drawing.Size(60, 22);
            this.y_1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "X1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(158, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "X2:";
            // 
            // y_2
            // 
            this.y_2.Location = new System.Drawing.Point(208, 74);
            this.y_2.Name = "y_2";
            this.y_2.Size = new System.Drawing.Size(60, 22);
            this.y_2.TabIndex = 9;
            // 
            // x_2
            // 
            this.x_2.Location = new System.Drawing.Point(208, 46);
            this.x_2.Name = "x_2";
            this.x_2.Size = new System.Drawing.Size(60, 22);
            this.x_2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(316, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(315, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "X3:";
            // 
            // y_3
            // 
            this.y_3.Location = new System.Drawing.Point(366, 72);
            this.y_3.Name = "y_3";
            this.y_3.Size = new System.Drawing.Size(60, 22);
            this.y_3.TabIndex = 13;
            // 
            // x_3
            // 
            this.x_3.Location = new System.Drawing.Point(366, 44);
            this.x_3.Name = "x_3";
            this.x_3.Size = new System.Drawing.Size(60, 22);
            this.x_3.TabIndex = 12;
            // 
            // Form_triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 156);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.y_3);
            this.Controls.Add(this.x_3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.y_2);
            this.Controls.Add(this.x_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y_1);
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.x_1);
            this.Controls.Add(this.label1);
            this.Name = "Form_triangle";
            this.Text = "Form_triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x_1;
        private System.Windows.Forms.Button Btn_create;
        private System.Windows.Forms.TextBox y_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y_2;
        private System.Windows.Forms.TextBox x_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox y_3;
        private System.Windows.Forms.TextBox x_3;
    }
}
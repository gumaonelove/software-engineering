namespace Lab2
{
    partial class Form_sq
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
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sq_w = new System.Windows.Forms.TextBox();
            this.sq_y = new System.Windows.Forms.TextBox();
            this.sq_x = new System.Windows.Forms.TextBox();
            this.Sq_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(19, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "W:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "X:";
            // 
            // sq_w
            // 
            this.sq_w.Location = new System.Drawing.Point(77, 101);
            this.sq_w.Name = "sq_w";
            this.sq_w.Size = new System.Drawing.Size(186, 22);
            this.sq_w.TabIndex = 32;
            // 
            // sq_y
            // 
            this.sq_y.Location = new System.Drawing.Point(77, 69);
            this.sq_y.Name = "sq_y";
            this.sq_y.Size = new System.Drawing.Size(186, 22);
            this.sq_y.TabIndex = 31;
            // 
            // sq_x
            // 
            this.sq_x.Location = new System.Drawing.Point(77, 41);
            this.sq_x.Name = "sq_x";
            this.sq_x.Size = new System.Drawing.Size(186, 22);
            this.sq_x.TabIndex = 30;
            // 
            // Sq_create
            // 
            this.Sq_create.Location = new System.Drawing.Point(16, 138);
            this.Sq_create.Name = "Sq_create";
            this.Sq_create.Size = new System.Drawing.Size(247, 42);
            this.Sq_create.TabIndex = 29;
            this.Sq_create.Text = "Создать";
            this.Sq_create.UseVisualStyleBackColor = true;
            this.Sq_create.Click += new System.EventHandler(this.Sq_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Введите параметры фигуры";
            // 
            // Form_sq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sq_w);
            this.Controls.Add(this.sq_y);
            this.Controls.Add(this.sq_x);
            this.Controls.Add(this.Sq_create);
            this.Name = "Form_sq";
            this.Text = "Form_sq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sq_w;
        private System.Windows.Forms.TextBox sq_y;
        private System.Windows.Forms.TextBox sq_x;
        private System.Windows.Forms.Button Sq_create;
        private System.Windows.Forms.Label label1;
    }
}
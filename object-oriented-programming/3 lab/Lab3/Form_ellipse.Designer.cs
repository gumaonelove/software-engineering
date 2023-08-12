namespace Lab2
{
    partial class Form_ellipse
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.el_r2 = new System.Windows.Forms.TextBox();
            this.el_r1 = new System.Windows.Forms.TextBox();
            this.el_y = new System.Windows.Forms.TextBox();
            this.el_x = new System.Windows.Forms.TextBox();
            this.El_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "R2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "R1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "X:";
            // 
            // el_r2
            // 
            this.el_r2.Location = new System.Drawing.Point(65, 116);
            this.el_r2.Name = "el_r2";
            this.el_r2.Size = new System.Drawing.Size(194, 22);
            this.el_r2.TabIndex = 36;
            // 
            // el_r1
            // 
            this.el_r1.Location = new System.Drawing.Point(65, 88);
            this.el_r1.Name = "el_r1";
            this.el_r1.Size = new System.Drawing.Size(194, 22);
            this.el_r1.TabIndex = 35;
            // 
            // el_y
            // 
            this.el_y.Location = new System.Drawing.Point(65, 60);
            this.el_y.Name = "el_y";
            this.el_y.Size = new System.Drawing.Size(194, 22);
            this.el_y.TabIndex = 34;
            // 
            // el_x
            // 
            this.el_x.Location = new System.Drawing.Point(65, 32);
            this.el_x.Name = "el_x";
            this.el_x.Size = new System.Drawing.Size(194, 22);
            this.el_x.TabIndex = 33;
            // 
            // El_create
            // 
            this.El_create.Location = new System.Drawing.Point(12, 144);
            this.El_create.Name = "El_create";
            this.El_create.Size = new System.Drawing.Size(247, 42);
            this.El_create.TabIndex = 32;
            this.El_create.Text = "Создать";
            this.El_create.UseVisualStyleBackColor = true;
            this.El_create.Click += new System.EventHandler(this.El_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Введите параметры фигуры";
            // 
            // Form_ellipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.el_r2);
            this.Controls.Add(this.el_r1);
            this.Controls.Add(this.el_y);
            this.Controls.Add(this.el_x);
            this.Controls.Add(this.El_create);
            this.Name = "Form_ellipse";
            this.Text = "Form_ellipse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox el_r2;
        private System.Windows.Forms.TextBox el_r1;
        private System.Windows.Forms.TextBox el_y;
        private System.Windows.Forms.TextBox el_x;
        private System.Windows.Forms.Button El_create;
        private System.Windows.Forms.Label label2;
    }
}
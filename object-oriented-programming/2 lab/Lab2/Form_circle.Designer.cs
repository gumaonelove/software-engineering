namespace Lab2
{
    partial class Form_circle
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
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.circ_r = new System.Windows.Forms.TextBox();
            this.circ_y = new System.Windows.Forms.TextBox();
            this.circ_x = new System.Windows.Forms.TextBox();
            this.Circle_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(9, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 25);
            this.label14.TabIndex = 39;
            this.label14.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "X:";
            // 
            // circ_r
            // 
            this.circ_r.Location = new System.Drawing.Point(66, 88);
            this.circ_r.Name = "circ_r";
            this.circ_r.Size = new System.Drawing.Size(193, 22);
            this.circ_r.TabIndex = 36;
            // 
            // circ_y
            // 
            this.circ_y.Location = new System.Drawing.Point(66, 60);
            this.circ_y.Name = "circ_y";
            this.circ_y.Size = new System.Drawing.Size(193, 22);
            this.circ_y.TabIndex = 35;
            // 
            // circ_x
            // 
            this.circ_x.Location = new System.Drawing.Point(66, 32);
            this.circ_x.Name = "circ_x";
            this.circ_x.Size = new System.Drawing.Size(193, 22);
            this.circ_x.TabIndex = 34;
            // 
            // Circle_create
            // 
            this.Circle_create.Location = new System.Drawing.Point(13, 116);
            this.Circle_create.Name = "Circle_create";
            this.Circle_create.Size = new System.Drawing.Size(246, 42);
            this.Circle_create.TabIndex = 33;
            this.Circle_create.Text = "Создать";
            this.Circle_create.UseVisualStyleBackColor = true;
            this.Circle_create.Click += new System.EventHandler(this.Circle_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Введите параметры фигуры";
            // 
            // Form_circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circ_r);
            this.Controls.Add(this.circ_y);
            this.Controls.Add(this.circ_x);
            this.Controls.Add(this.Circle_create);
            this.Name = "Form_circle";
            this.Text = "Form_circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox circ_r;
        private System.Windows.Forms.TextBox circ_y;
        private System.Windows.Forms.TextBox circ_x;
        private System.Windows.Forms.Button Circle_create;
        private System.Windows.Forms.Label label2;
    }
}
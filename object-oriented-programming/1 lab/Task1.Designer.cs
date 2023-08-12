namespace Lab1
{
    partial class Task1
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
            this.x_in = new System.Windows.Forms.TextBox();
            this.z_in = new System.Windows.Forms.TextBox();
            this.y_in = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.x_out = new System.Windows.Forms.TextBox();
            this.y_out = new System.Windows.Forms.TextBox();
            this.z_out = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // x_in
            // 
            this.x_in.Location = new System.Drawing.Point(59, 40);
            this.x_in.Name = "x_in";
            this.x_in.Size = new System.Drawing.Size(88, 22);
            this.x_in.TabIndex = 3;
            // 
            // z_in
            // 
            this.z_in.Location = new System.Drawing.Point(57, 126);
            this.z_in.Name = "z_in";
            this.z_in.Size = new System.Drawing.Size(90, 22);
            this.z_in.TabIndex = 4;
            // 
            // y_in
            // 
            this.y_in.Location = new System.Drawing.Point(59, 85);
            this.y_in.Name = "y_in";
            this.y_in.Size = new System.Drawing.Size(88, 22);
            this.y_in.TabIndex = 5;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(169, 72);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(101, 49);
            this.Btn.TabIndex = 6;
            this.Btn.Text = "Вычислить";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // x_out
            // 
            this.x_out.Location = new System.Drawing.Point(286, 40);
            this.x_out.Name = "x_out";
            this.x_out.ReadOnly = true;
            this.x_out.Size = new System.Drawing.Size(74, 22);
            this.x_out.TabIndex = 7;
            // 
            // y_out
            // 
            this.y_out.Location = new System.Drawing.Point(286, 85);
            this.y_out.Name = "y_out";
            this.y_out.ReadOnly = true;
            this.y_out.Size = new System.Drawing.Size(74, 22);
            this.y_out.TabIndex = 8;
            // 
            // z_out
            // 
            this.z_out.Location = new System.Drawing.Point(286, 126);
            this.z_out.Name = "z_out";
            this.z_out.ReadOnly = true;
            this.z_out.Size = new System.Drawing.Size(74, 22);
            this.z_out.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y:";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 182);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.z_out);
            this.Controls.Add(this.y_out);
            this.Controls.Add(this.x_out);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.y_in);
            this.Controls.Add(this.z_in);
            this.Controls.Add(this.x_in);
            this.Controls.Add(this.label1);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x_in;
        private System.Windows.Forms.TextBox z_in;
        private System.Windows.Forms.TextBox y_in;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox x_out;
        private System.Windows.Forms.TextBox y_out;
        private System.Windows.Forms.TextBox z_out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace Lab2
{
    partial class Form2
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
            this.change_rect_h = new System.Windows.Forms.TextBox();
            this.change_rect_w = new System.Windows.Forms.TextBox();
            this.change_rect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "H:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "W:";
            // 
            // change_rect_h
            // 
            this.change_rect_h.Location = new System.Drawing.Point(68, 40);
            this.change_rect_h.Name = "change_rect_h";
            this.change_rect_h.Size = new System.Drawing.Size(70, 22);
            this.change_rect_h.TabIndex = 31;
            // 
            // change_rect_w
            // 
            this.change_rect_w.Location = new System.Drawing.Point(68, 12);
            this.change_rect_w.Name = "change_rect_w";
            this.change_rect_w.Size = new System.Drawing.Size(70, 22);
            this.change_rect_w.TabIndex = 30;
            // 
            // change_rect
            // 
            this.change_rect.Location = new System.Drawing.Point(159, 12);
            this.change_rect.Name = "change_rect";
            this.change_rect.Size = new System.Drawing.Size(109, 50);
            this.change_rect.TabIndex = 34;
            this.change_rect.Text = "Изменить";
            this.change_rect.UseVisualStyleBackColor = true;
            this.change_rect.Click += new System.EventHandler(this.change_rect_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 83);
            this.Controls.Add(this.change_rect);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.change_rect_h);
            this.Controls.Add(this.change_rect_w);
            this.Name = "Form2";
            this.Text = "Изменение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox change_rect_h;
        private System.Windows.Forms.TextBox change_rect_w;
        private System.Windows.Forms.Button change_rect;
    }
}
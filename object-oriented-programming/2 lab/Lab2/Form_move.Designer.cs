namespace Lab2
{
    partial class Form_move
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.move_to_y = new System.Windows.Forms.TextBox();
            this.move_to_x = new System.Windows.Forms.TextBox();
            this.Btn_move = new System.Windows.Forms.Button();
            this.Btn_move_all = new System.Windows.Forms.Button();
            this.Btn_move_rect = new System.Windows.Forms.Button();
            this.Btn_move_sq = new System.Windows.Forms.Button();
            this.Btn_move_ellipse = new System.Windows.Forms.Button();
            this.Btn_move_circle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(244, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 25);
            this.label16.TabIndex = 44;
            this.label16.Text = "Y:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(242, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 43;
            this.label15.Text = "X:";
            // 
            // move_to_y
            // 
            this.move_to_y.Location = new System.Drawing.Point(280, 40);
            this.move_to_y.Name = "move_to_y";
            this.move_to_y.Size = new System.Drawing.Size(81, 22);
            this.move_to_y.TabIndex = 42;
            // 
            // move_to_x
            // 
            this.move_to_x.Location = new System.Drawing.Point(280, 12);
            this.move_to_x.Name = "move_to_x";
            this.move_to_x.Size = new System.Drawing.Size(81, 22);
            this.move_to_x.TabIndex = 41;
            // 
            // Btn_move
            // 
            this.Btn_move.Location = new System.Drawing.Point(16, 77);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(177, 67);
            this.Btn_move.TabIndex = 40;
            this.Btn_move.Text = "переместить выбранную";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // Btn_move_all
            // 
            this.Btn_move_all.Location = new System.Drawing.Point(16, 163);
            this.Btn_move_all.Name = "Btn_move_all";
            this.Btn_move_all.Size = new System.Drawing.Size(177, 67);
            this.Btn_move_all.TabIndex = 45;
            this.Btn_move_all.Text = "переместить все";
            this.Btn_move_all.UseVisualStyleBackColor = true;
            this.Btn_move_all.Click += new System.EventHandler(this.Btn_move_all_Click);
            // 
            // Btn_move_rect
            // 
            this.Btn_move_rect.Location = new System.Drawing.Point(209, 77);
            this.Btn_move_rect.Name = "Btn_move_rect";
            this.Btn_move_rect.Size = new System.Drawing.Size(177, 67);
            this.Btn_move_rect.TabIndex = 46;
            this.Btn_move_rect.Text = "переместить прямоугольники";
            this.Btn_move_rect.UseVisualStyleBackColor = true;
            this.Btn_move_rect.Click += new System.EventHandler(this.Btn_move_rect_Click);
            // 
            // Btn_move_sq
            // 
            this.Btn_move_sq.Location = new System.Drawing.Point(209, 163);
            this.Btn_move_sq.Name = "Btn_move_sq";
            this.Btn_move_sq.Size = new System.Drawing.Size(177, 67);
            this.Btn_move_sq.TabIndex = 47;
            this.Btn_move_sq.Text = "переместить квадраты";
            this.Btn_move_sq.UseVisualStyleBackColor = true;
            this.Btn_move_sq.Click += new System.EventHandler(this.Btn_move_sq_Click);
            // 
            // Btn_move_ellipse
            // 
            this.Btn_move_ellipse.Location = new System.Drawing.Point(402, 77);
            this.Btn_move_ellipse.Name = "Btn_move_ellipse";
            this.Btn_move_ellipse.Size = new System.Drawing.Size(177, 67);
            this.Btn_move_ellipse.TabIndex = 48;
            this.Btn_move_ellipse.Text = "переместить эллипсы";
            this.Btn_move_ellipse.UseVisualStyleBackColor = true;
            this.Btn_move_ellipse.Click += new System.EventHandler(this.Btn_move_ellipse_Click);
            // 
            // Btn_move_circle
            // 
            this.Btn_move_circle.Location = new System.Drawing.Point(402, 163);
            this.Btn_move_circle.Name = "Btn_move_circle";
            this.Btn_move_circle.Size = new System.Drawing.Size(177, 67);
            this.Btn_move_circle.TabIndex = 49;
            this.Btn_move_circle.Text = "переместить окружности";
            this.Btn_move_circle.UseVisualStyleBackColor = true;
            this.Btn_move_circle.Click += new System.EventHandler(this.Btn_move_circle_Click);
            // 
            // Form_move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 253);
            this.Controls.Add(this.Btn_move_circle);
            this.Controls.Add(this.Btn_move_ellipse);
            this.Controls.Add(this.Btn_move_sq);
            this.Controls.Add(this.Btn_move_rect);
            this.Controls.Add(this.Btn_move_all);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.move_to_y);
            this.Controls.Add(this.move_to_x);
            this.Controls.Add(this.Btn_move);
            this.Name = "Form_move";
            this.Text = "Перемещение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox move_to_y;
        private System.Windows.Forms.TextBox move_to_x;
        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button Btn_move_all;
        private System.Windows.Forms.Button Btn_move_rect;
        private System.Windows.Forms.Button Btn_move_sq;
        private System.Windows.Forms.Button Btn_move_ellipse;
        private System.Windows.Forms.Button Btn_move_circle;
    }
}
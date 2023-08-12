namespace Lab1
{
    partial class Task3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.res_textBox = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.res_label = new System.Windows.Forms.Label();
            this.Btn_reroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(100, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Искомая сумма:";
            // 
            // res_textBox
            // 
            this.res_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textBox.Location = new System.Drawing.Point(282, 344);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.ReadOnly = true;
            this.res_textBox.Size = new System.Drawing.Size(100, 30);
            this.res_textBox.TabIndex = 2;
            // 
            // Btn
            // 
            this.Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn.Location = new System.Drawing.Point(12, 296);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(195, 45);
            this.Btn.TabIndex = 3;
            this.Btn.Text = "Вычислить";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_label.Location = new System.Drawing.Point(7, 400);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(0, 20);
            this.res_label.TabIndex = 5;
            // 
            // Btn_reroll
            // 
            this.Btn_reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_reroll.Location = new System.Drawing.Point(12, 347);
            this.Btn_reroll.Name = "Btn_reroll";
            this.Btn_reroll.Size = new System.Drawing.Size(195, 45);
            this.Btn_reroll.TabIndex = 6;
            this.Btn_reroll.Text = "Сгенерировать матрицу";
            this.Btn_reroll.UseVisualStyleBackColor = true;
            this.Btn_reroll.Click += new System.EventHandler(this.Btn_reroll_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.Btn_reroll);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Task3";
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox res_textBox;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.Button Btn_reroll;
    }
}
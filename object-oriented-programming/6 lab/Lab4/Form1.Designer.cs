namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.commandsList = new System.Windows.Forms.ComboBox();
            this.pictureBoxWindow = new System.Windows.Forms.PictureBox();
            this.listBoxFigures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.BackColor = System.Drawing.Color.Black;
            this.textBoxInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputString.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxInputString.Location = new System.Drawing.Point(12, 12);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(369, 30);
            this.textBoxInputString.TabIndex = 0;
            this.textBoxInputString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInputString_KeyDown);
            // 
            // commandsList
            // 
            this.commandsList.AllowDrop = true;
            this.commandsList.DropDownWidth = 250;
            this.commandsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandsList.FormattingEnabled = true;
            this.commandsList.Location = new System.Drawing.Point(387, 12);
            this.commandsList.Name = "commandsList";
            this.commandsList.Size = new System.Drawing.Size(157, 26);
            this.commandsList.TabIndex = 1;
            this.commandsList.Text = "История команд";
            // 
            // pictureBoxWindow
            // 
            this.pictureBoxWindow.BackColor = System.Drawing.Color.White;
            this.pictureBoxWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWindow.Location = new System.Drawing.Point(12, 60);
            this.pictureBoxWindow.Name = "pictureBoxWindow";
            this.pictureBoxWindow.Size = new System.Drawing.Size(532, 378);
            this.pictureBoxWindow.TabIndex = 2;
            this.pictureBoxWindow.TabStop = false;
            // 
            // listBoxFigures
            // 
            this.listBoxFigures.FormattingEnabled = true;
            this.listBoxFigures.ItemHeight = 16;
            this.listBoxFigures.Location = new System.Drawing.Point(550, 12);
            this.listBoxFigures.Name = "listBoxFigures";
            this.listBoxFigures.Size = new System.Drawing.Size(236, 420);
            this.listBoxFigures.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.listBoxFigures);
            this.Controls.Add(this.pictureBoxWindow);
            this.Controls.Add(this.commandsList);
            this.Controls.Add(this.textBoxInputString);
            this.Name = "Form1";
            this.Text = "Lab4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.ComboBox commandsList;
        private System.Windows.Forms.PictureBox pictureBoxWindow;
        private System.Windows.Forms.ListBox listBoxFigures;
    }
}


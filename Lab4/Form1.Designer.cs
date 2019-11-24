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
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.labelRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(21, 63);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(133, 51);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "СЧИТАТЬ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Введите слово";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(415, 64);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(127, 50);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "НАЙТИ";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(378, 152);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 144);
            this.listBox.TabIndex = 4;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(443, 41);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(73, 20);
            this.labelFind.TabIndex = 5;
            this.labelFind.Text = "labelFind";
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Location = new System.Drawing.Point(38, 120);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(81, 20);
            this.labelRead.TabIndex = 6;
            this.labelRead.Text = "labelRead";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Label labelRead;
    }
}


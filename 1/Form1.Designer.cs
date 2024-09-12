namespace _1
{
    partial class Блакнот
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
            this.Закрыть = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(113, 109);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(75, 23);
            this.Закрыть.TabIndex = 0;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Блакнот
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Закрыть);
            this.Name = "Блакнот";
            this.Text = "Блакнот";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Закрыть;
    }
}


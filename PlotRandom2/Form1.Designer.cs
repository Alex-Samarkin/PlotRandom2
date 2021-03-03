
namespace PlotRandom2
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
            PlotRandom2.ClassSample classSample1 = new PlotRandom2.ClassSample();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new PlotRandom2.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ввести параметры генератора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.userControl11.Location = new System.Drawing.Point(0, 23);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Padding = new System.Windows.Forms.Padding(5);
            classSample1.X = null;
            classSample1.Y = null;
            this.userControl11.Sample = classSample1;
            this.userControl11.Size = new System.Drawing.Size(311, 487);
            this.userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UserControl1 userControl11;
    }
}


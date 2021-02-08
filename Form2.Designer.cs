
namespace SimpleCalculator
{
    partial class Form2
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
            this.exponentiatoin = new System.Windows.Forms.Button();
            this.ExtractSquare = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.SquareNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exponentiatoin
            // 
            this.exponentiatoin.Location = new System.Drawing.Point(305, 130);
            this.exponentiatoin.Name = "exponentiatoin";
            this.exponentiatoin.Size = new System.Drawing.Size(66, 46);
            this.exponentiatoin.TabIndex = 23;
            this.exponentiatoin.TabStop = false;
            this.exponentiatoin.Text = "x^y";
            this.exponentiatoin.UseVisualStyleBackColor = true;
            this.exponentiatoin.Click += new System.EventHandler(this.exponentiatoin_Click);
            // 
            // ExtractSquare
            // 
            this.ExtractSquare.Location = new System.Drawing.Point(305, 185);
            this.ExtractSquare.Name = "ExtractSquare";
            this.ExtractSquare.Size = new System.Drawing.Size(66, 47);
            this.ExtractSquare.TabIndex = 24;
            this.ExtractSquare.TabStop = false;
            this.ExtractSquare.Text = "\\/x";
            this.ExtractSquare.UseVisualStyleBackColor = true;
            this.ExtractSquare.Click += new System.EventHandler(this.ExtractSquare_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(305, 241);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(66, 46);
            this.Reverse.TabIndex = 25;
            this.Reverse.TabStop = false;
            this.Reverse.Text = "1/x";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // SquareNumber
            // 
            this.SquareNumber.Location = new System.Drawing.Point(305, 296);
            this.SquareNumber.Name = "SquareNumber";
            this.SquareNumber.Size = new System.Drawing.Size(66, 46);
            this.SquareNumber.TabIndex = 26;
            this.SquareNumber.TabStop = false;
            this.SquareNumber.Text = "x^2";
            this.SquareNumber.UseVisualStyleBackColor = true;
            this.SquareNumber.Click += new System.EventHandler(this.SquareNumber_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(383, 419);
            this.Controls.Add(this.SquareNumber);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.ExtractSquare);
            this.Controls.Add(this.exponentiatoin);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.exponentiatoin, 0);
            this.Controls.SetChildIndex(this.ExtractSquare, 0);
            this.Controls.SetChildIndex(this.Reverse, 0);
            this.Controls.SetChildIndex(this.SquareNumber, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exponentiatoin;
        private System.Windows.Forms.Button ExtractSquare;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button SquareNumber;
    }
}

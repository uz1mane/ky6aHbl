namespace cubes
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
            this.btFirst = new System.Windows.Forms.Button();
            this.btSecond = new System.Windows.Forms.Button();
            this.btAnswer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFirst
            // 
            this.btFirst.BackColor = System.Drawing.Color.White;
            this.btFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFirst.Location = new System.Drawing.Point(12, 12);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(372, 237);
            this.btFirst.TabIndex = 0;
            this.btFirst.Text = "First dice: ";
            this.btFirst.UseVisualStyleBackColor = false;
            // 
            // btSecond
            // 
            this.btSecond.BackColor = System.Drawing.Color.Black;
            this.btSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSecond.ForeColor = System.Drawing.Color.White;
            this.btSecond.Location = new System.Drawing.Point(416, 12);
            this.btSecond.Name = "btSecond";
            this.btSecond.Size = new System.Drawing.Size(372, 237);
            this.btSecond.TabIndex = 1;
            this.btSecond.Text = "Second dice: ";
            this.btSecond.UseVisualStyleBackColor = false;
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer.Location = new System.Drawing.Point(12, 255);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(776, 183);
            this.btAnswer.TabIndex = 2;
            this.btAnswer.Text = "Dice №  wins!";
            this.btAnswer.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(381, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 237);
            this.button4.TabIndex = 3;
            this.button4.Text = "PLAY";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.btSecond);
            this.Controls.Add(this.btFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btSecond;
        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.Button button4;
    }
}


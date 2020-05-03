namespace Course
{
    partial class Title
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
            this.Title_label = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_label.Location = new System.Drawing.Point(12, 22);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(931, 92);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "                        Добро пожаловать!\r\nВам необходимо войти или зарегистриров" +
    "аться\r\n";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(305, 139);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(315, 138);
            this.Input.TabIndex = 1;
            this.Input.Text = "Вход";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(305, 294);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(315, 138);
            this.Registration.TabIndex = 2;
            this.Registration.Text = "Регистрация\r\n";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(20, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Title_label);
            this.Name = "Title";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button button1;
    }
}


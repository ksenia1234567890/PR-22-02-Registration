namespace PR_22_02_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tsurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tlogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // Tsurname
            // 
            this.Tsurname.Location = new System.Drawing.Point(61, 62);
            this.Tsurname.Multiline = true;
            this.Tsurname.Name = "Tsurname";
            this.Tsurname.Size = new System.Drawing.Size(164, 24);
            this.Tsurname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(61, 157);
            this.Tname.Multiline = true;
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(164, 24);
            this.Tname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Логин";
            // 
            // Tlogin
            // 
            this.Tlogin.Location = new System.Drawing.Point(288, 62);
            this.Tlogin.Multiline = true;
            this.Tlogin.Name = "Tlogin";
            this.Tlogin.Size = new System.Drawing.Size(164, 24);
            this.Tlogin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль";
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(288, 157);
            this.Tpassword.Multiline = true;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(164, 24);
            this.Tpassword.TabIndex = 1;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(403, 215);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(115, 26);
            this.reg.TabIndex = 2;
            this.reg.Text = "Зарегистрировать";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 215);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 26);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 253);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tsurname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Регистрация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tsurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button exit;
    }
}


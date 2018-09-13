namespace testing_program
{
    partial class Form_Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorization));
            this.Btn_login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Serial_Number = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.Btn_admin = new System.Windows.Forms.Button();
            this.btn_insert_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(41, 169);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 1;
            this.Btn_login.Text = "Вход";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Серийный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(78, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авторизация в программе тестирования ЭИАС УПР";
            // 
            // tb_Serial_Number
            // 
            this.tb_Serial_Number.Location = new System.Drawing.Point(301, 84);
            this.tb_Serial_Number.Name = "tb_Serial_Number";
            this.tb_Serial_Number.Size = new System.Drawing.Size(100, 20);
            this.tb_Serial_Number.TabIndex = 6;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(301, 121);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(100, 20);
            this.tb_Password.TabIndex = 7;
            // 
            // Btn_admin
            // 
            this.Btn_admin.Location = new System.Drawing.Point(173, 169);
            this.Btn_admin.Name = "Btn_admin";
            this.Btn_admin.Size = new System.Drawing.Size(162, 23);
            this.Btn_admin.TabIndex = 8;
            this.Btn_admin.Text = "Войти под администратором";
            this.Btn_admin.UseVisualStyleBackColor = true;
            this.Btn_admin.Click += new System.EventHandler(this.Btn_admin_Click);
            // 
            // btn_insert_data
            // 
            this.btn_insert_data.Location = new System.Drawing.Point(474, 169);
            this.btn_insert_data.Name = "btn_insert_data";
            this.btn_insert_data.Size = new System.Drawing.Size(99, 23);
            this.btn_insert_data.TabIndex = 9;
            this.btn_insert_data.Text = "Ввод данных";
            this.btn_insert_data.UseVisualStyleBackColor = true;
            this.btn_insert_data.Click += new System.EventHandler(this.btn_insert_data_Click);
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 249);
            this.Controls.Add(this.btn_insert_data);
            this.Controls.Add(this.Btn_admin);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Serial_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Authorization";
            this.Text = "ЭИАС УПР";
            this.Load += new System.EventHandler(this.Form_Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Serial_Number;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button Btn_admin;
        private System.Windows.Forms.Button btn_insert_data;
    }
}


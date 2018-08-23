namespace testing_program
{
    partial class Form_new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_new_user));
            this.tb_new_Serial_Number = new System.Windows.Forms.TextBox();
            this.tb_new_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.btn_create_new_user = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_select_employ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_new_Serial_Number
            // 
            this.tb_new_Serial_Number.Location = new System.Drawing.Point(168, 64);
            this.tb_new_Serial_Number.Name = "tb_new_Serial_Number";
            this.tb_new_Serial_Number.Size = new System.Drawing.Size(100, 20);
            this.tb_new_Serial_Number.TabIndex = 0;
            // 
            // tb_new_password
            // 
            this.tb_new_password.Location = new System.Drawing.Point(168, 101);
            this.tb_new_password.Name = "tb_new_password";
            this.tb_new_password.Size = new System.Drawing.Size(100, 20);
            this.tb_new_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серийный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Location = new System.Drawing.Point(58, 140);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(105, 17);
            this.checkBox_admin.TabIndex = 2;
            this.checkBox_admin.Text = "Администратор";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // btn_create_new_user
            // 
            this.btn_create_new_user.Location = new System.Drawing.Point(58, 223);
            this.btn_create_new_user.Name = "btn_create_new_user";
            this.btn_create_new_user.Size = new System.Drawing.Size(75, 23);
            this.btn_create_new_user.TabIndex = 4;
            this.btn_create_new_user.Text = "Создать";
            this.btn_create_new_user.UseVisualStyleBackColor = true;
            this.btn_create_new_user.Click += new System.EventHandler(this.btn_create_new_user_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(193, 223);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_select_employ
            // 
            this.cb_select_employ.FormattingEnabled = true;
            this.cb_select_employ.Location = new System.Drawing.Point(58, 164);
            this.cb_select_employ.Name = "cb_select_employ";
            this.cb_select_employ.Size = new System.Drawing.Size(210, 21);
            this.cb_select_employ.TabIndex = 3;
            this.cb_select_employ.Text = "Выберите сотрудника";
            // 
            // Form_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 291);
            this.Controls.Add(this.cb_select_employ);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_create_new_user);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_new_password);
            this.Controls.Add(this.tb_new_Serial_Number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_new_user";
            this.Text = "Предоставление доступа пользователю";
            this.Load += new System.EventHandler(this.Form_new_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_new_Serial_Number;
        private System.Windows.Forms.TextBox tb_new_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_admin;
        private System.Windows.Forms.Button btn_create_new_user;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cb_select_employ;
    }
}
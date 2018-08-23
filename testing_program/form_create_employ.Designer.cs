namespace testing_program
{
    partial class form_create_employ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_employ));
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Date_of_Birth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_create_new_employ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Surname
            // 
            this.tb_Surname.Location = new System.Drawing.Point(12, 51);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(100, 20);
            this.tb_Surname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(118, 51);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // tb_Patronymic
            // 
            this.tb_Patronymic.Location = new System.Drawing.Point(224, 51);
            this.tb_Patronymic.Name = "tb_Patronymic";
            this.tb_Patronymic.Size = new System.Drawing.Size(100, 20);
            this.tb_Patronymic.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отчество";
            // 
            // dt_Date_of_Birth
            // 
            this.dt_Date_of_Birth.Location = new System.Drawing.Point(343, 51);
            this.dt_Date_of_Birth.Name = "dt_Date_of_Birth";
            this.dt_Date_of_Birth.Size = new System.Drawing.Size(200, 20);
            this.dt_Date_of_Birth.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата рождения";
            // 
            // btn_create_new_employ
            // 
            this.btn_create_new_employ.Location = new System.Drawing.Point(95, 95);
            this.btn_create_new_employ.Name = "btn_create_new_employ";
            this.btn_create_new_employ.Size = new System.Drawing.Size(98, 23);
            this.btn_create_new_employ.TabIndex = 3;
            this.btn_create_new_employ.Text = "Создать";
            this.btn_create_new_employ.UseVisualStyleBackColor = true;
            this.btn_create_new_employ.Click += new System.EventHandler(this.btn_create_new_employ_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_create_employ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 130);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_create_new_employ);
            this.Controls.Add(this.dt_Date_of_Birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Patronymic);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Surname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_employ";
            this.Text = "Создание нового сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Date_of_Birth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_create_new_employ;
        private System.Windows.Forms.Button button2;
    }
}
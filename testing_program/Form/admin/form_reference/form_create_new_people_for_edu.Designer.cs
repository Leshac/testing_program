﻿namespace testing_program
{
    partial class form_create_new_people_for_edu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_new_people_for_edu));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_education = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_profession = new System.Windows.Forms.ComboBox();
            this.cb_qualification = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_family = new System.Windows.Forms.ComboBox();
            this.rtb_extra = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dtp_date_start_work = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_for_edu = new System.Windows.Forms.CheckBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_father_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(174, 12);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(244, 20);
            this.tb_LastName.TabIndex = 1;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(174, 92);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(244, 20);
            this.dtp_birthday.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата рождения";
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Location = new System.Drawing.Point(174, 118);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(244, 21);
            this.cb_sex.TabIndex = 4;
            this.cb_sex.DropDown += new System.EventHandler(this.cb_sex_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Образование";
            // 
            // cb_education
            // 
            this.cb_education.FormattingEnabled = true;
            this.cb_education.Location = new System.Drawing.Point(174, 145);
            this.cb_education.Name = "cb_education";
            this.cb_education.Size = new System.Drawing.Size(244, 21);
            this.cb_education.TabIndex = 7;
            this.cb_education.DropDown += new System.EventHandler(this.id_education_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Профессия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Квалификация";
            // 
            // cb_profession
            // 
            this.cb_profession.FormattingEnabled = true;
            this.cb_profession.Location = new System.Drawing.Point(174, 172);
            this.cb_profession.Name = "cb_profession";
            this.cb_profession.Size = new System.Drawing.Size(244, 21);
            this.cb_profession.TabIndex = 10;
            this.cb_profession.DropDown += new System.EventHandler(this.cb_profession_DropDown);
            // 
            // cb_qualification
            // 
            this.cb_qualification.FormattingEnabled = true;
            this.cb_qualification.Location = new System.Drawing.Point(174, 199);
            this.cb_qualification.Name = "cb_qualification";
            this.cb_qualification.Size = new System.Drawing.Size(244, 21);
            this.cb_qualification.TabIndex = 11;
            this.cb_qualification.DropDown += new System.EventHandler(this.cb_qualification_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Семейное положение";
            // 
            // cb_family
            // 
            this.cb_family.FormattingEnabled = true;
            this.cb_family.Location = new System.Drawing.Point(174, 230);
            this.cb_family.Name = "cb_family";
            this.cb_family.Size = new System.Drawing.Size(244, 21);
            this.cb_family.TabIndex = 13;
            this.cb_family.DropDown += new System.EventHandler(this.cb_family_DropDown);
            // 
            // rtb_extra
            // 
            this.rtb_extra.Location = new System.Drawing.Point(31, 302);
            this.rtb_extra.Name = "rtb_extra";
            this.rtb_extra.Size = new System.Drawing.Size(387, 51);
            this.rtb_extra.TabIndex = 14;
            this.rtb_extra.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дополнительная информация";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(220, 390);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(343, 390);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dtp_date_start_work
            // 
            this.dtp_date_start_work.Location = new System.Drawing.Point(174, 258);
            this.dtp_date_start_work.Name = "dtp_date_start_work";
            this.dtp_date_start_work.Size = new System.Drawing.Size(244, 20);
            this.dtp_date_start_work.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата начала работы";
            // 
            // cb_for_edu
            // 
            this.cb_for_edu.AutoSize = true;
            this.cb_for_edu.Location = new System.Drawing.Point(31, 360);
            this.cb_for_edu.Name = "cb_for_edu";
            this.cb_for_edu.Size = new System.Drawing.Size(185, 17);
            this.cb_for_edu.TabIndex = 20;
            this.cb_for_edu.Text = "Данные для обучения системы";
            this.cb_for_edu.UseVisualStyleBackColor = true;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(174, 39);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(244, 20);
            this.tb_Name.TabIndex = 21;
            // 
            // tb_father_name
            // 
            this.tb_father_name.Location = new System.Drawing.Point(174, 66);
            this.tb_father_name.Name = "tb_father_name";
            this.tb_father_name.Size = new System.Drawing.Size(244, 20);
            this.tb_father_name.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Имя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Отчество";
            // 
            // form_create_new_people_for_edu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 480);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_father_name);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cb_for_edu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_date_start_work);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_extra);
            this.Controls.Add(this.cb_family);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_qualification);
            this.Controls.Add(this.cb_profession);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_education);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_new_people_for_edu";
            this.Text = "Создание нового сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_education;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_profession;
        private System.Windows.Forms.ComboBox cb_qualification;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_family;
        private System.Windows.Forms.RichTextBox rtb_extra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker dtp_date_start_work;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_for_edu;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_father_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
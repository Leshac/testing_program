namespace testing_program
{
    partial class form_create_new_accident_for_edu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_new_accident_for_edu));
            this.btn_create_new_type_accident = new System.Windows.Forms.Button();
            this.cb_SIZ = new System.Windows.Forms.CheckBox();
            this.cb_Alcohol = new System.Windows.Forms.CheckBox();
            this.tb_Age_on_accident = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_Datetime_accident = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_type_accident = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_people_for_edu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_seriousness = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Time_acc_work = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dayweek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_create_new_type_accident
            // 
            this.btn_create_new_type_accident.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_type_accident.Image")));
            this.btn_create_new_type_accident.Location = new System.Drawing.Point(441, 47);
            this.btn_create_new_type_accident.Name = "btn_create_new_type_accident";
            this.btn_create_new_type_accident.Size = new System.Drawing.Size(24, 21);
            this.btn_create_new_type_accident.TabIndex = 8;
            this.btn_create_new_type_accident.UseVisualStyleBackColor = true;
            this.btn_create_new_type_accident.Click += new System.EventHandler(this.btn_create_new_type_accident_Click);
            // 
            // cb_SIZ
            // 
            this.cb_SIZ.AutoSize = true;
            this.cb_SIZ.Location = new System.Drawing.Point(34, 280);
            this.cb_SIZ.Name = "cb_SIZ";
            this.cb_SIZ.Size = new System.Drawing.Size(203, 17);
            this.cb_SIZ.TabIndex = 7;
            this.cb_SIZ.Text = "Средство индивидуальной защиты";
            this.cb_SIZ.UseVisualStyleBackColor = true;
            // 
            // cb_Alcohol
            // 
            this.cb_Alcohol.AutoSize = true;
            this.cb_Alcohol.Location = new System.Drawing.Point(34, 256);
            this.cb_Alcohol.Name = "cb_Alcohol";
            this.cb_Alcohol.Size = new System.Drawing.Size(161, 17);
            this.cb_Alcohol.TabIndex = 6;
            this.cb_Alcohol.Text = "Наличие алкоголя в крови";
            this.cb_Alcohol.UseVisualStyleBackColor = true;
            // 
            // tb_Age_on_accident
            // 
            this.tb_Age_on_accident.Location = new System.Drawing.Point(235, 142);
            this.tb_Age_on_accident.Name = "tb_Age_on_accident";
            this.tb_Age_on_accident.ReadOnly = true;
            this.tb_Age_on_accident.Size = new System.Drawing.Size(200, 20);
            this.tb_Age_on_accident.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Возраст на момент происшествия";
            // 
            // dt_Datetime_accident
            // 
            this.dt_Datetime_accident.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_Datetime_accident.Location = new System.Drawing.Point(235, 110);
            this.dt_Datetime_accident.Name = "dt_Datetime_accident";
            this.dt_Datetime_accident.Size = new System.Drawing.Size(200, 20);
            this.dt_Datetime_accident.TabIndex = 3;
            this.dt_Datetime_accident.CloseUp += new System.EventHandler(this.dt_Datetime_accident_CloseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата происшествия";
            // 
            // cb_type_accident
            // 
            this.cb_type_accident.FormattingEnabled = true;
            this.cb_type_accident.Location = new System.Drawing.Point(235, 47);
            this.cb_type_accident.Name = "cb_type_accident";
            this.cb_type_accident.Size = new System.Drawing.Size(200, 21);
            this.cb_type_accident.TabIndex = 1;
            this.cb_type_accident.DropDown += new System.EventHandler(this.cb_type_accident_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вид происшетвия";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(260, 312);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(390, 312);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сотрудник";
            // 
            // cb_people_for_edu
            // 
            this.cb_people_for_edu.FormattingEnabled = true;
            this.cb_people_for_edu.Location = new System.Drawing.Point(235, 15);
            this.cb_people_for_edu.Name = "cb_people_for_edu";
            this.cb_people_for_edu.Size = new System.Drawing.Size(200, 21);
            this.cb_people_for_edu.TabIndex = 10;
            this.cb_people_for_edu.DropDown += new System.EventHandler(this.cb_people_for_edu_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тяжесть последствий";
            // 
            // cb_seriousness
            // 
            this.cb_seriousness.FormattingEnabled = true;
            this.cb_seriousness.Location = new System.Drawing.Point(235, 75);
            this.cb_seriousness.Name = "cb_seriousness";
            this.cb_seriousness.Size = new System.Drawing.Size(200, 21);
            this.cb_seriousness.TabIndex = 12;
            this.cb_seriousness.DropDown += new System.EventHandler(this.cb_seriousness_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Время от начала рабочего дня";
            // 
            // tb_Time_acc_work
            // 
            this.tb_Time_acc_work.Location = new System.Drawing.Point(235, 173);
            this.tb_Time_acc_work.Name = "tb_Time_acc_work";
            this.tb_Time_acc_work.ReadOnly = true;
            this.tb_Time_acc_work.Size = new System.Drawing.Size(200, 20);
            this.tb_Time_acc_work.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "День недели";
            // 
            // tb_dayweek
            // 
            this.tb_dayweek.Location = new System.Drawing.Point(235, 200);
            this.tb_dayweek.Name = "tb_dayweek";
            this.tb_dayweek.ReadOnly = true;
            this.tb_dayweek.Size = new System.Drawing.Size(200, 20);
            this.tb_dayweek.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Месяц";
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(235, 230);
            this.tb_month.Name = "tb_month";
            this.tb_month.ReadOnly = true;
            this.tb_month.Size = new System.Drawing.Size(200, 20);
            this.tb_month.TabIndex = 18;
            // 
            // form_create_new_accident_for_edu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 347);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_dayweek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Time_acc_work);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_seriousness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_people_for_edu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_create_new_type_accident);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cb_SIZ);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cb_Alcohol);
            this.Controls.Add(this.tb_Age_on_accident);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_type_accident);
            this.Controls.Add(this.dt_Datetime_accident);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_new_accident_for_edu";
            this.Text = "Создание нового происшествия для обучения";
            this.Load += new System.EventHandler(this.form_create_new_accident_for_edu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_SIZ;
        private System.Windows.Forms.CheckBox cb_Alcohol;
        private System.Windows.Forms.TextBox tb_Age_on_accident;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_Datetime_accident;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_type_accident;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_create_new_type_accident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_people_for_edu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_seriousness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Time_acc_work;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dayweek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_month;
    }
}
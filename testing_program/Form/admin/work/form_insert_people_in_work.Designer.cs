namespace testing_program
{
    partial class form_insert_people_in_work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_insert_people_in_work));
            this.cb_people_for_edu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_enterprise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date_enter = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date_remove = new System.Windows.Forms.DateTimePicker();
            this.cb_work_on_prof = new System.Windows.Forms.CheckBox();
            this.cb_remove = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_shedule = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_conditions = new System.Windows.Forms.ComboBox();
            this.cb_internship = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_date_start_internship = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_date_end_internship = new System.Windows.Forms.DateTimePicker();
            this.cb_OVPF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_SOUT_ARM = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_people_for_edu
            // 
            this.cb_people_for_edu.FormattingEnabled = true;
            this.cb_people_for_edu.Location = new System.Drawing.Point(193, 12);
            this.cb_people_for_edu.Name = "cb_people_for_edu";
            this.cb_people_for_edu.Size = new System.Drawing.Size(321, 21);
            this.cb_people_for_edu.TabIndex = 0;
            this.cb_people_for_edu.DropDown += new System.EventHandler(this.cb_people_for_edu_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // cb_enterprise
            // 
            this.cb_enterprise.FormattingEnabled = true;
            this.cb_enterprise.Location = new System.Drawing.Point(193, 51);
            this.cb_enterprise.Name = "cb_enterprise";
            this.cb_enterprise.Size = new System.Drawing.Size(321, 21);
            this.cb_enterprise.TabIndex = 2;
            this.cb_enterprise.DropDown += new System.EventHandler(this.cb_enterprise_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предприятие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата принятия на работу";
            // 
            // dtp_date_enter
            // 
            this.dtp_date_enter.Location = new System.Drawing.Point(193, 85);
            this.dtp_date_enter.Name = "dtp_date_enter";
            this.dtp_date_enter.Size = new System.Drawing.Size(321, 20);
            this.dtp_date_enter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата увольнения";
            // 
            // dtp_date_remove
            // 
            this.dtp_date_remove.Location = new System.Drawing.Point(193, 114);
            this.dtp_date_remove.Name = "dtp_date_remove";
            this.dtp_date_remove.Size = new System.Drawing.Size(200, 20);
            this.dtp_date_remove.TabIndex = 7;
            // 
            // cb_work_on_prof
            // 
            this.cb_work_on_prof.AutoSize = true;
            this.cb_work_on_prof.Location = new System.Drawing.Point(25, 149);
            this.cb_work_on_prof.Name = "cb_work_on_prof";
            this.cb_work_on_prof.Size = new System.Drawing.Size(157, 17);
            this.cb_work_on_prof.TabIndex = 8;
            this.cb_work_on_prof.Text = "Работа по специальности";
            this.cb_work_on_prof.UseVisualStyleBackColor = true;
            // 
            // cb_remove
            // 
            this.cb_remove.AutoSize = true;
            this.cb_remove.Location = new System.Drawing.Point(399, 117);
            this.cb_remove.Name = "cb_remove";
            this.cb_remove.Size = new System.Drawing.Size(64, 17);
            this.cb_remove.TabIndex = 9;
            this.cb_remove.Text = "Уволен";
            this.cb_remove.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "График рабочего времени";
            // 
            // cb_shedule
            // 
            this.cb_shedule.FormattingEnabled = true;
            this.cb_shedule.Location = new System.Drawing.Point(193, 177);
            this.cb_shedule.Name = "cb_shedule";
            this.cb_shedule.Size = new System.Drawing.Size(321, 21);
            this.cb_shedule.TabIndex = 11;
            this.cb_shedule.DropDown += new System.EventHandler(this.cb_shedule_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Условия труда";
            // 
            // cb_conditions
            // 
            this.cb_conditions.FormattingEnabled = true;
            this.cb_conditions.Location = new System.Drawing.Point(193, 211);
            this.cb_conditions.Name = "cb_conditions";
            this.cb_conditions.Size = new System.Drawing.Size(321, 21);
            this.cb_conditions.TabIndex = 13;
            this.cb_conditions.DropDown += new System.EventHandler(this.cb_conditions_DropDown);
            // 
            // cb_internship
            // 
            this.cb_internship.AutoSize = true;
            this.cb_internship.Location = new System.Drawing.Point(193, 149);
            this.cb_internship.Name = "cb_internship";
            this.cb_internship.Size = new System.Drawing.Size(138, 17);
            this.cb_internship.TabIndex = 14;
            this.cb_internship.Text = "Проходил стажировку";
            this.cb_internship.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата начала стажировки";
            // 
            // dtp_date_start_internship
            // 
            this.dtp_date_start_internship.Location = new System.Drawing.Point(193, 248);
            this.dtp_date_start_internship.Name = "dtp_date_start_internship";
            this.dtp_date_start_internship.Size = new System.Drawing.Size(321, 20);
            this.dtp_date_start_internship.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Дата окончания стажировки";
            // 
            // dtp_date_end_internship
            // 
            this.dtp_date_end_internship.Location = new System.Drawing.Point(193, 276);
            this.dtp_date_end_internship.Name = "dtp_date_end_internship";
            this.dtp_date_end_internship.Size = new System.Drawing.Size(321, 20);
            this.dtp_date_end_internship.TabIndex = 18;
            // 
            // cb_OVPF
            // 
            this.cb_OVPF.FormattingEnabled = true;
            this.cb_OVPF.Location = new System.Drawing.Point(193, 311);
            this.cb_OVPF.Name = "cb_OVPF";
            this.cb_OVPF.Size = new System.Drawing.Size(321, 21);
            this.cb_OVPF.TabIndex = 20;
            this.cb_OVPF.DropDown += new System.EventHandler(this.cb_OVPF_DropDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ОВПФ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "СОУТ/АРМ";
            // 
            // tb_SOUT_ARM
            // 
            this.tb_SOUT_ARM.Location = new System.Drawing.Point(193, 348);
            this.tb_SOUT_ARM.Name = "tb_SOUT_ARM";
            this.tb_SOUT_ARM.Size = new System.Drawing.Size(321, 20);
            this.tb_SOUT_ARM.TabIndex = 23;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(318, 381);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 24;
            this.btn_create.Text = "Добавить";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(439, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // form_insert_people_in_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 416);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cb_internship);
            this.Controls.Add(this.dtp_date_end_internship);
            this.Controls.Add(this.tb_SOUT_ARM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_date_start_internship);
            this.Controls.Add(this.cb_OVPF);
            this.Controls.Add(this.cb_conditions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_shedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_remove);
            this.Controls.Add(this.cb_work_on_prof);
            this.Controls.Add(this.dtp_date_remove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_date_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_enterprise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_people_for_edu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_insert_people_in_work";
            this.Text = "Добавление истории работы сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_people_for_edu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_enterprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date_enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date_remove;
        private System.Windows.Forms.CheckBox cb_work_on_prof;
        private System.Windows.Forms.CheckBox cb_remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_shedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_conditions;
        private System.Windows.Forms.CheckBox cb_internship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_date_start_internship;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_date_end_internship;
        private System.Windows.Forms.ComboBox cb_OVPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_SOUT_ARM;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
    }
}
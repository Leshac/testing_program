namespace testing_program
{
    partial class form_create_new_check_knowledge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_new_check_knowledge));
            this.cb_id_people_for_edu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_id_type_check = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date_check = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_id_type_result_check = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_id_people_for_edu
            // 
            this.cb_id_people_for_edu.FormattingEnabled = true;
            this.cb_id_people_for_edu.Location = new System.Drawing.Point(163, 19);
            this.cb_id_people_for_edu.Name = "cb_id_people_for_edu";
            this.cb_id_people_for_edu.Size = new System.Drawing.Size(229, 21);
            this.cb_id_people_for_edu.TabIndex = 0;
            this.cb_id_people_for_edu.DropDown += new System.EventHandler(this.cb_id_people_for_edu_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // cb_id_type_check
            // 
            this.cb_id_type_check.FormattingEnabled = true;
            this.cb_id_type_check.Location = new System.Drawing.Point(163, 57);
            this.cb_id_type_check.Name = "cb_id_type_check";
            this.cb_id_type_check.Size = new System.Drawing.Size(229, 21);
            this.cb_id_type_check.TabIndex = 2;
            this.cb_id_type_check.DropDown += new System.EventHandler(this.cb_id_type_check_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип проверки знаний";
            // 
            // dtp_date_check
            // 
            this.dtp_date_check.Location = new System.Drawing.Point(163, 100);
            this.dtp_date_check.Name = "dtp_date_check";
            this.dtp_date_check.Size = new System.Drawing.Size(229, 20);
            this.dtp_date_check.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата проверки знаний";
            // 
            // cb_id_type_result_check
            // 
            this.cb_id_type_result_check.FormattingEnabled = true;
            this.cb_id_type_result_check.Location = new System.Drawing.Point(163, 141);
            this.cb_id_type_result_check.Name = "cb_id_type_result_check";
            this.cb_id_type_result_check.Size = new System.Drawing.Size(229, 21);
            this.cb_id_type_result_check.TabIndex = 6;
            this.cb_id_type_result_check.DropDown += new System.EventHandler(this.cb_id_type_result_check_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат проверки";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(179, 193);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Добавить";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(317, 193);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // form_create_new_check_knowledge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 228);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_id_type_result_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_id_type_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_id_people_for_edu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_new_check_knowledge";
            this.Text = "Добавление новой проверки знаний";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_id_people_for_edu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_id_type_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_id_type_result_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
    }
}
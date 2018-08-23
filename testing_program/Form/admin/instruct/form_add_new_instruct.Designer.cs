namespace testing_program
{
    partial class form_add_new_instruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_add_new_instruct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type_instruct = new System.Windows.Forms.ComboBox();
            this.cb_topic_instruct = new System.Windows.Forms.ComboBox();
            this.dt_date_Date_instr = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_new_instruct = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_create_new_type_instruct = new System.Windows.Forms.Button();
            this.btn_create_new_topic_instruct = new System.Windows.Forms.Button();
            this.btn_create_new_people_for_edu = new System.Windows.Forms.Button();
            this.clb_people_for_edu = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип инструктажа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тема инструктажа";
            // 
            // cb_type_instruct
            // 
            this.cb_type_instruct.FormattingEnabled = true;
            this.cb_type_instruct.Location = new System.Drawing.Point(158, 27);
            this.cb_type_instruct.Name = "cb_type_instruct";
            this.cb_type_instruct.Size = new System.Drawing.Size(255, 21);
            this.cb_type_instruct.TabIndex = 1;
            this.cb_type_instruct.DropDown += new System.EventHandler(this.cb_type_instruct_DropDown);
            this.cb_type_instruct.SelectedIndexChanged += new System.EventHandler(this.cb_type_instruct_SelectedIndexChanged);
            this.cb_type_instruct.DropDownClosed += new System.EventHandler(this.cb_type_instruct_DropDownClosed);
            // 
            // cb_topic_instruct
            // 
            this.cb_topic_instruct.FormattingEnabled = true;
            this.cb_topic_instruct.Location = new System.Drawing.Point(158, 59);
            this.cb_topic_instruct.Name = "cb_topic_instruct";
            this.cb_topic_instruct.Size = new System.Drawing.Size(255, 21);
            this.cb_topic_instruct.TabIndex = 1;
            this.cb_topic_instruct.DropDown += new System.EventHandler(this.cb_topic_instruct_DropDown);
            // 
            // dt_date_Date_instr
            // 
            this.dt_date_Date_instr.Location = new System.Drawing.Point(158, 103);
            this.dt_date_Date_instr.Name = "dt_date_Date_instr";
            this.dt_date_Date_instr.Size = new System.Drawing.Size(255, 20);
            this.dt_date_Date_instr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата проведения";
            // 
            // btn_add_new_instruct
            // 
            this.btn_add_new_instruct.Location = new System.Drawing.Point(292, 236);
            this.btn_add_new_instruct.Name = "btn_add_new_instruct";
            this.btn_add_new_instruct.Size = new System.Drawing.Size(75, 23);
            this.btn_add_new_instruct.TabIndex = 4;
            this.btn_add_new_instruct.Text = "Добавить";
            this.btn_add_new_instruct.UseVisualStyleBackColor = true;
            this.btn_add_new_instruct.Click += new System.EventHandler(this.btn_add_new_instruct_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(419, 236);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Инструктируемые";
            // 
            // btn_create_new_type_instruct
            // 
            this.btn_create_new_type_instruct.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_type_instruct.Image")));
            this.btn_create_new_type_instruct.Location = new System.Drawing.Point(420, 27);
            this.btn_create_new_type_instruct.Name = "btn_create_new_type_instruct";
            this.btn_create_new_type_instruct.Size = new System.Drawing.Size(25, 21);
            this.btn_create_new_type_instruct.TabIndex = 7;
            this.btn_create_new_type_instruct.UseVisualStyleBackColor = true;
            this.btn_create_new_type_instruct.Click += new System.EventHandler(this.btn_create_new_type_instruct_Click);
            // 
            // btn_create_new_topic_instruct
            // 
            this.btn_create_new_topic_instruct.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_topic_instruct.Image")));
            this.btn_create_new_topic_instruct.Location = new System.Drawing.Point(420, 59);
            this.btn_create_new_topic_instruct.Name = "btn_create_new_topic_instruct";
            this.btn_create_new_topic_instruct.Size = new System.Drawing.Size(25, 21);
            this.btn_create_new_topic_instruct.TabIndex = 8;
            this.btn_create_new_topic_instruct.UseVisualStyleBackColor = true;
            this.btn_create_new_topic_instruct.Click += new System.EventHandler(this.btn_create_new_topic_instruct_Click);
            // 
            // btn_create_new_people_for_edu
            // 
            this.btn_create_new_people_for_edu.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_people_for_edu.Image")));
            this.btn_create_new_people_for_edu.Location = new System.Drawing.Point(419, 136);
            this.btn_create_new_people_for_edu.Name = "btn_create_new_people_for_edu";
            this.btn_create_new_people_for_edu.Size = new System.Drawing.Size(25, 21);
            this.btn_create_new_people_for_edu.TabIndex = 9;
            this.btn_create_new_people_for_edu.UseVisualStyleBackColor = true;
            this.btn_create_new_people_for_edu.Click += new System.EventHandler(this.btn_create_new_people_for_edu_Click);
            // 
            // clb_people_for_edu
            // 
            this.clb_people_for_edu.CheckOnClick = true;
            this.clb_people_for_edu.FormattingEnabled = true;
            this.clb_people_for_edu.Location = new System.Drawing.Point(158, 136);
            this.clb_people_for_edu.Name = "clb_people_for_edu";
            this.clb_people_for_edu.ScrollAlwaysVisible = true;
            this.clb_people_for_edu.Size = new System.Drawing.Size(255, 94);
            this.clb_people_for_edu.TabIndex = 10;
            // 
            // form_add_new_instruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 264);
            this.Controls.Add(this.clb_people_for_edu);
            this.Controls.Add(this.btn_create_new_people_for_edu);
            this.Controls.Add(this.btn_create_new_topic_instruct);
            this.Controls.Add(this.btn_create_new_type_instruct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add_new_instruct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_date_Date_instr);
            this.Controls.Add(this.cb_topic_instruct);
            this.Controls.Add(this.cb_type_instruct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_add_new_instruct";
            this.Text = "Добавление нового проведенного инструктажа";
            this.Load += new System.EventHandler(this.form_add_new_instruct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type_instruct;
        private System.Windows.Forms.ComboBox cb_topic_instruct;
        private System.Windows.Forms.DateTimePicker dt_date_Date_instr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_new_instruct;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_create_new_type_instruct;
        private System.Windows.Forms.Button btn_create_new_topic_instruct;
        private System.Windows.Forms.Button btn_create_new_people_for_edu;
        private System.Windows.Forms.CheckedListBox clb_people_for_edu;
    }
}
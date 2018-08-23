namespace testing_program
{
    partial class form_create_new_Instruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_new_Instruct));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_type_instruct = new System.Windows.Forms.ComboBox();
            this.cb_topic_instruct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Date_instr = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_create_new_type_instruct = new System.Windows.Forms.Button();
            this.btn_create_new_topic_instruct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип инструктажа";
            // 
            // cb_type_instruct
            // 
            this.cb_type_instruct.FormattingEnabled = true;
            this.cb_type_instruct.Location = new System.Drawing.Point(47, 51);
            this.cb_type_instruct.Name = "cb_type_instruct";
            this.cb_type_instruct.Size = new System.Drawing.Size(271, 21);
            this.cb_type_instruct.TabIndex = 1;
            this.cb_type_instruct.DropDown += new System.EventHandler(this.cb_type_instruct_DropDown);
            // 
            // cb_topic_instruct
            // 
            this.cb_topic_instruct.FormattingEnabled = true;
            this.cb_topic_instruct.Location = new System.Drawing.Point(47, 91);
            this.cb_topic_instruct.Name = "cb_topic_instruct";
            this.cb_topic_instruct.Size = new System.Drawing.Size(271, 21);
            this.cb_topic_instruct.TabIndex = 2;
            this.cb_topic_instruct.DropDown += new System.EventHandler(this.cb_topic_instruct_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тема инструктажа";
            // 
            // dtp_Date_instr
            // 
            this.dtp_Date_instr.Location = new System.Drawing.Point(47, 135);
            this.dtp_Date_instr.Name = "dtp_Date_instr";
            this.dtp_Date_instr.Size = new System.Drawing.Size(271, 20);
            this.dtp_Date_instr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата инструктажа";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(124, 172);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Добавить";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(243, 172);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_create_new_type_instruct
            // 
            this.btn_create_new_type_instruct.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_type_instruct.Image")));
            this.btn_create_new_type_instruct.Location = new System.Drawing.Point(324, 51);
            this.btn_create_new_type_instruct.Name = "btn_create_new_type_instruct";
            this.btn_create_new_type_instruct.Size = new System.Drawing.Size(25, 21);
            this.btn_create_new_type_instruct.TabIndex = 7;
            this.btn_create_new_type_instruct.UseVisualStyleBackColor = true;
            this.btn_create_new_type_instruct.Click += new System.EventHandler(this.btn_create_new_type_instruct_Click);
            // 
            // btn_create_new_topic_instruct
            // 
            this.btn_create_new_topic_instruct.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_topic_instruct.Image")));
            this.btn_create_new_topic_instruct.Location = new System.Drawing.Point(324, 91);
            this.btn_create_new_topic_instruct.Name = "btn_create_new_topic_instruct";
            this.btn_create_new_topic_instruct.Size = new System.Drawing.Size(25, 21);
            this.btn_create_new_topic_instruct.TabIndex = 8;
            this.btn_create_new_topic_instruct.UseVisualStyleBackColor = true;
            this.btn_create_new_topic_instruct.Click += new System.EventHandler(this.btn_create_new_topic_instruct_Click);
            // 
            // form_create_new_Instruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 214);
            this.Controls.Add(this.btn_create_new_topic_instruct);
            this.Controls.Add(this.btn_create_new_type_instruct);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Date_instr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_topic_instruct);
            this.Controls.Add(this.cb_type_instruct);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_new_Instruct";
            this.Text = "Добавление проведенного инструктажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_type_instruct;
        private System.Windows.Forms.ComboBox cb_topic_instruct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Date_instr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_create_new_type_instruct;
        private System.Windows.Forms.Button btn_create_new_topic_instruct;
    }
}
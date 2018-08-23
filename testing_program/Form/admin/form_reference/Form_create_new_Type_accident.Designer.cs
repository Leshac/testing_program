namespace testing_program
{
    partial class Form_create_new_Type_accident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_create_new_Type_accident));
            this.btn_create_new_type_accident = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_number_type_accident = new System.Windows.Forms.TextBox();
            this.tb_name_type_accident = new System.Windows.Forms.TextBox();
            this.tb_key_type_accident = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create_new_type_accident
            // 
            this.btn_create_new_type_accident.Location = new System.Drawing.Point(42, 176);
            this.btn_create_new_type_accident.Name = "btn_create_new_type_accident";
            this.btn_create_new_type_accident.Size = new System.Drawing.Size(75, 23);
            this.btn_create_new_type_accident.TabIndex = 0;
            this.btn_create_new_type_accident.Text = "Создать";
            this.btn_create_new_type_accident.UseVisualStyleBackColor = true;
            this.btn_create_new_type_accident.Click += new System.EventHandler(this.btn_create_new_type_accident_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(150, 176);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_number_type_accident
            // 
            this.tb_number_type_accident.Location = new System.Drawing.Point(42, 54);
            this.tb_number_type_accident.Name = "tb_number_type_accident";
            this.tb_number_type_accident.Size = new System.Drawing.Size(151, 20);
            this.tb_number_type_accident.TabIndex = 1;
            // 
            // tb_name_type_accident
            // 
            this.tb_name_type_accident.Location = new System.Drawing.Point(42, 93);
            this.tb_name_type_accident.Name = "tb_name_type_accident";
            this.tb_name_type_accident.Size = new System.Drawing.Size(387, 20);
            this.tb_name_type_accident.TabIndex = 1;
            // 
            // tb_key_type_accident
            // 
            this.tb_key_type_accident.Location = new System.Drawing.Point(42, 132);
            this.tb_key_type_accident.Name = "tb_key_type_accident";
            this.tb_key_type_accident.Size = new System.Drawing.Size(151, 20);
            this.tb_key_type_accident.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер вида происшествия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование вида происшествия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код вида происшествия";
            // 
            // Form_create_new_Type_accident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_key_type_accident);
            this.Controls.Add(this.tb_name_type_accident);
            this.Controls.Add(this.tb_number_type_accident);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create_new_type_accident);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_create_new_Type_accident";
            this.Text = "Создание нового вида происшествия";
            this.Load += new System.EventHandler(this.Form_create_new_Type_accident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_new_type_accident;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_number_type_accident;
        private System.Windows.Forms.TextBox tb_name_type_accident;
        private System.Windows.Forms.TextBox tb_key_type_accident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
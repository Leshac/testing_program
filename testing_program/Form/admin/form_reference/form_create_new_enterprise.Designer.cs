namespace testing_program
{
    partial class form_create_new_enterprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_create_new_enterprise));
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cb_OKVED = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create_new_OKVED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(49, 203);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(179, 203);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cb_OKVED
            // 
            this.cb_OKVED.FormattingEnabled = true;
            this.cb_OKVED.Location = new System.Drawing.Point(32, 112);
            this.cb_OKVED.Name = "cb_OKVED";
            this.cb_OKVED.Size = new System.Drawing.Size(270, 21);
            this.cb_OKVED.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(32, 63);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(270, 20);
            this.tb_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование предприятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ОКВЭД";
            // 
            // btn_create_new_OKVED
            // 
            this.btn_create_new_OKVED.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_new_OKVED.Image")));
            this.btn_create_new_OKVED.Location = new System.Drawing.Point(309, 112);
            this.btn_create_new_OKVED.Name = "btn_create_new_OKVED";
            this.btn_create_new_OKVED.Size = new System.Drawing.Size(24, 21);
            this.btn_create_new_OKVED.TabIndex = 5;
            this.btn_create_new_OKVED.UseVisualStyleBackColor = true;
            this.btn_create_new_OKVED.Click += new System.EventHandler(this.btn_create_new_OKVED_Click);
            // 
            // form_create_new_enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 252);
            this.Controls.Add(this.btn_create_new_OKVED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.cb_OKVED);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_create_new_enterprise";
            this.Text = "Создание нового предприятия";
            this.Load += new System.EventHandler(this.form_create_new_enterprise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cb_OKVED;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create_new_OKVED;
    }
}
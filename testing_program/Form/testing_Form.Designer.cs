namespace testing_program
{
    partial class Form_CHOOSING_TESTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CHOOSING_TESTS));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_topic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(233, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тест который необходимо пройти";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(237, 241);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(110, 38);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "Выбрать";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(533, 241);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 38);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_topic
            // 
            this.lb_topic.FormattingEnabled = true;
            this.lb_topic.ItemHeight = 22;
            this.lb_topic.Location = new System.Drawing.Point(237, 106);
            this.lb_topic.Name = "lb_topic";
            this.lb_topic.Size = new System.Drawing.Size(386, 48);
            this.lb_topic.TabIndex = 6;
            // 
            // Form_CHOOSING_TESTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 387);
            this.Controls.Add(this.lb_topic);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_CHOOSING_TESTS";
            this.Text = "ЭИАС УПР";
            this.Load += new System.EventHandler(this.Form_CHOOSING_TESTS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListBox lb_topic;
    }
}
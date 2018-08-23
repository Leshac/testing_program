namespace testing_program
{
    partial class form_admin_result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_admin_result));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_testing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct_questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not_correct_questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_of_testing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Name,
            this.Patronymic,
            this.data_testing,
            this.correct_questions,
            this.not_correct_questions,
            this.topic_of_testing});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // data_testing
            // 
            this.data_testing.HeaderText = "Дата тестирования";
            this.data_testing.Name = "data_testing";
            this.data_testing.ReadOnly = true;
            // 
            // correct_questions
            // 
            this.correct_questions.HeaderText = "Правильных ответов";
            this.correct_questions.Name = "correct_questions";
            this.correct_questions.ReadOnly = true;
            // 
            // not_correct_questions
            // 
            this.not_correct_questions.HeaderText = "Не правильных ответов";
            this.not_correct_questions.Name = "not_correct_questions";
            this.not_correct_questions.ReadOnly = true;
            // 
            // topic_of_testing
            // 
            this.topic_of_testing.HeaderText = "Тематика тестирования";
            this.topic_of_testing.Name = "topic_of_testing";
            this.topic_of_testing.ReadOnly = true;
            // 
            // form_admin_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "form_admin_result";
            this.Text = "Результаты тестирования";
            this.Load += new System.EventHandler(this.form_admin_result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnswers1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnswers2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnswers3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnswers4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnswers5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTopicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_testing;
        private System.Windows.Forms.DataGridViewTextBoxColumn correct_questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn not_correct_questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_of_testing;
    }
}
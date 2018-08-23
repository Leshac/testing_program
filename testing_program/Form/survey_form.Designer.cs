using System;

namespace testing_program
{
    partial class FORM_survey_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_survey_form));
            this.reply = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reply
            // 
            this.reply.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reply.Location = new System.Drawing.Point(195, 389);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(114, 34);
            this.reply.TabIndex = 2;
            this.reply.Text = "Ответить";
            this.reply.UseVisualStyleBackColor = true;
            this.reply.Click += new System.EventHandler(this.reply_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(608, 389);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(114, 34);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FORM_survey_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 469);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_survey_form";
            this.Text = "Тестирование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FORM_survey_form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button reply;
        private System.Windows.Forms.Button exit;
        private readonly EventHandler question_TextChanged;
    }
}
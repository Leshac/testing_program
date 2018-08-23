namespace testing_program
{
    partial class Form_output_of_all_incidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_output_of_all_incidents));
            this.DGV_all_incidents = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_all_incidents)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_all_incidents
            // 
            this.DGV_all_incidents.AllowUserToAddRows = false;
            this.DGV_all_incidents.AllowUserToDeleteRows = false;
            this.DGV_all_incidents.AllowUserToOrderColumns = true;
            this.DGV_all_incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_all_incidents.Location = new System.Drawing.Point(13, 13);
            this.DGV_all_incidents.Name = "DGV_all_incidents";
            this.DGV_all_incidents.ReadOnly = true;
            this.DGV_all_incidents.Size = new System.Drawing.Size(1018, 407);
            this.DGV_all_incidents.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(871, 427);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form_output_of_all_incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 458);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.DGV_all_incidents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_output_of_all_incidents";
            this.Text = "Инциденты внесенные в программу";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_all_incidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_all_incidents;
        private System.Windows.Forms.Button btn_exit;
    }
}
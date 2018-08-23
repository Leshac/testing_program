using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_program
{
    public partial class Form_new_user : Form
    {
        public Form_new_user()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_new_user_Click(object sender, EventArgs e)
        {
            if (tb_new_Serial_Number.Text != "" && tb_new_password.Text != "")
            {
                try
                 {
                
                string sqlString = "INSERT INTO [Authorization] (serial_number,password,admin,id_people_for_edu) VALUES (N'" + tb_new_Serial_Number.Text + "',N'" + tb_new_password.Text + "','" + checkBox_admin.Checked + "','" + this.cb_select_employ.SelectedValue + "'); ";
                Create_SQL_Command create_SQL_Command = new Create_SQL_Command(sqlString);
                    SqlCommand sqlCommand=create_SQL_Command.get_SQL_Command();
                    sqlCommand.ExecuteNonQuery();
                    this.Close();
                }
               catch {
                    MessageBox.Show("Ошибка добавления записи");
                }
            }

        }

        private void Form_new_user_Load(object sender, EventArgs e)
        {
            string sqlString_get_employ = "SELECT fulname=concat(lastname,Name,fathername),id FROM [people_for_edu]";
            Get_DataTable get_DataTable = new Get_DataTable(sqlString_get_employ);
            this.cb_select_employ.DataSource = get_DataTable.get_DataTable();
            this.cb_select_employ.DisplayMember = "fulname";// столбец для отображения
            this.cb_select_employ.ValueMember = "id";//столбец с id
            this.cb_select_employ.SelectedIndex = -1;
        }
    }
    
}
